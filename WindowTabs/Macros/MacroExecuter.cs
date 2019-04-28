using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Diagnostics;

namespace WindowTabs
{
    class MacroExecuter
    {
        System.ComponentModel.BackgroundWorker worker;

        Macro macro;
        IntPtr targetWindow;
        public MacroExecuter(Macro macroToExecute)
        {
            macro = macroToExecute;
            targetWindow = IntPtr.Zero;
            worker = new System.ComponentModel.BackgroundWorker();
            worker.DoWork += ExecuteMacro;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            IntPtr currentWindow = IntPtr.Zero;
            uint currentProcessID;
            string[] seperateClassNames = macro.macroClassPath.Split('>');
            if (seperateClassNames.Length <= 0)
            {
                MessageBox.Show("class name invalid when attempting to run Macro(MacroExecuter)");
                return;
            }
            else if (seperateClassNames.Length == 1)
            {
                //validate it's the correct window by checking the process name
                while (WinApi.FindWindowEx(IntPtr.Zero, currentWindow, seperateClassNames[0], null) != IntPtr.Zero)
                {
                    currentWindow = WinApi.FindWindowEx(IntPtr.Zero, currentWindow, seperateClassNames[0], null);

                    WinApi.GetWindowThreadProcessId(currentWindow, out currentProcessID);
                    if (Process.GetProcessById((int)currentProcessID).ProcessName == macro.macroProcessName)
                    {
                        targetWindow = currentWindow;
                        //MouseDown("Left,1025,978,");
                        //MouseUp("Left,1025,978,");
                    }
                    //WinApi.GetWindowThreadProcessId(whatWindow, out processID);
                    //process = Process.GetProcessById((int)processID);
                }
            }
            else
            {
                //validate it's the correct window by checking the process name
                while (WinApi.FindWindowEx(IntPtr.Zero, currentWindow, seperateClassNames[0], null) != IntPtr.Zero)
                {
                    currentWindow = WinApi.FindWindowEx(IntPtr.Zero, currentWindow, seperateClassNames[0], null);

                    WinApi.GetWindowThreadProcessId(currentWindow, out currentProcessID);
                    if (Process.GetProcessById((int)currentProcessID).ProcessName == macro.macroProcessName)
                    {
                        targetWindow = currentWindow;
                        //MouseDown("Left,1025,978,");
                        //MouseUp("Left,1025,978,");
                    }
                    //WinApi.GetWindowThreadProcessId(whatWindow, out processID);
                    //process = Process.GetProcessById((int)processID);
                }
                for (int i = 1; i < seperateClassNames.Length; i++)
                {
                    targetWindow = WinApi.FindWindowEx(targetWindow,IntPtr.Zero, seperateClassNames[i], null);
                }
            }

            worker.RunWorkerAsync();

        }

        public event EventHandler<SpecialCommandArgs> PassTheKeys;
        protected virtual void OnSpecialCommand(SpecialCommandArgs e)
        {
            EventHandler<SpecialCommandArgs> handler = PassTheKeys;
            if (handler != null) handler(this, e);
        }
        public class SpecialCommandArgs
        {
            public MacroAction.ActionType actionType { get; }
            public string parameters { get; }
            public SpecialCommandArgs(MacroAction.ActionType type, string commandParameters)
            {
                actionType = type;
                parameters = commandParameters;
            }
        }

        private void Worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
        }
        private void ExecuteMacro(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //IntPtr windowToSendInputTo = 
            //if(macro.directInput == true) { WinApi.SetForegroundWindow(macro.macroClassPath)}
            for (int i = 0; i < macro.macroActions.Count; i++)
            {
                switch (macro.macroActions[i].actionType)
                {
                    case MacroAction.ActionType.KeyDown:
                        KeyDown(macro.macroActions[i].parameters);
                        break;
                    case MacroAction.ActionType.KeyUp:
                        KeyUp(macro.macroActions[i].parameters);
                        break;
                    case MacroAction.ActionType.MouseClick:
                        MouseClick(macro.macroActions[i].parameters);
                        break;
                    case MacroAction.ActionType.MouseDown:
                        MouseDown(macro.macroActions[i].parameters);
                        break;
                    case MacroAction.ActionType.MouseUp:
                        MouseUp(macro.macroActions[i].parameters);
                        break;
                        //special case
                    case MacroAction.ActionType.PassKeys:
                        PassKeys();
                        break;
                    case MacroAction.ActionType.Wait:
                        Wait(macro.macroActions[i].parameters);
                        break;
                    case MacroAction.ActionType.TypeKey:
                        TypeKey(macro.macroActions[i].parameters);
                        break;
                    //special case
                    case MacroAction.ActionType.RunMacro:
                        RunMacro(macro.macroActions[i].parameters);
                        break;
                    default:
                        break;
                }
            }
        }
        private void KeyDown(string whichKey)
        {
            Keys thisKey;
            if (Enum.TryParse<Keys>(whichKey, out thisKey))
            {
                uint scanCode = WinApi.MapVirtualKey((uint)thisKey, 0);
                uint lParam = (0x00000001 | (scanCode << 16));
                WinApi.PostMessage(targetWindow, (int)WinApi.KeyAction.WM_KEYDOWN, Convert.ToInt32(thisKey), (IntPtr)(lParam));
            }
            else
            {
                MessageBox.Show("can't parse key + " + whichKey + " in function KeyDown");
            }
        }
        private void KeyUp(string whichKey)
        {
            Keys thisKey;
            if (Enum.TryParse<Keys>(whichKey, out thisKey))
            {
                uint scanCode = WinApi.MapVirtualKey((uint)thisKey, 0);
                uint lParam = (0x00000001 | (scanCode << 16));
                WinApi.PostMessage(targetWindow, (int)WinApi.KeyAction.WM_KEYUP, Convert.ToInt32(thisKey), (IntPtr)(lParam));
            }
            else
            {
                MessageBox.Show("can't parse key + " + whichKey + " in function KeyUp");
            }
        }
        private void MouseClick(string parameters)
        {
            MouseDown(parameters);
            MouseUp(parameters);
        }
        private void MouseDown(string parameters)
        {
            const int requiredParamCount = 4;

            string[] splitParams = parameters.Split(',');
            WinApi.WParamMouse wParamMouse;
            int xpos = 0;
            int ypos = 0;

            if (splitParams.Length == requiredParamCount)
            {
                switch (splitParams[0])
                {
                    case "Left":
                        wParamMouse = WinApi.WParamMouse.WM_LBUTTONDOWN;
                        break;
                    case "Right":
                        wParamMouse = WinApi.WParamMouse.WM_RBUTTONDOWN;
                        break;
                    case "Middle":
                        wParamMouse = WinApi.WParamMouse.WM_MBUTTONDOWN;
                        break;
                    default:
                        MessageBox.Show("couldn't parse mouse button type in MouseDown function");
                        return;
                }
                if (int.TryParse(splitParams[1], out xpos))
                {

                }
                else Console.WriteLine("couldn't parse xpos parameter using default value(0)");
                if (int.TryParse(splitParams[2], out ypos))
                {

                }
                else Console.WriteLine("couldn't parse xpos parameter using default value(0)");
                //
                //
                //impliment image searcher here and use it to attempt finding image location
                //if it doesn't find the image then don't run the command
                //
                //
                //if the parameter is emtpy then just click at that position on the window
                if (splitParams[3] == "")
                {
                    WinApi.PostMessage(targetWindow, (uint)wParamMouse, 0, WinApi.LPARAMMOUSECOORDS(xpos, ypos));
                }
            }
            else
            {
                MessageBox.Show("incorrect parameter count for MouseDown function");
                return;
            }
        }
        private void MouseUp(string parameters)
        {
            const int requiredParamCount = 4;

            string[] splitParams = parameters.Split(',');
            WinApi.WParamMouse wParamMouse;
            int xpos = 0;
            int ypos = 0;

            if (splitParams.Length == requiredParamCount)
            {
                switch (splitParams[0])
                {
                    case "Left":
                        wParamMouse = WinApi.WParamMouse.WM_LBUTTONUP;
                        break;
                    case "Right":
                        wParamMouse = WinApi.WParamMouse.WM_RBUTTONUP;
                        break;
                    case "Middle":
                        wParamMouse = WinApi.WParamMouse.WM_MBUTTONUP;
                        break;
                    default:
                        MessageBox.Show("couldn't parse mouse button type in MouseDown function");
                        return;
                }
                if (int.TryParse(splitParams[1], out xpos))
                {

                }
                else Console.WriteLine("couldn't parse xpos parameter using default value(0)");
                if (int.TryParse(splitParams[2], out ypos))
                {

                }
                else Console.WriteLine("couldn't parse xpos parameter using default value(0)");
                //
                //
                //impliment image searcher here and use it to attempt finding image location
                //if it doesn't find the image then don't run the command
                //
                //
                //if the parameter is emtpy then just click at that position on the window
                if (splitParams[3] == "")
                {
                    WinApi.PostMessage(targetWindow, (uint)wParamMouse, 0, WinApi.LPARAMMOUSECOORDS(xpos, ypos));
                }
            }
            else
            {
                MessageBox.Show("incorrect parameter count for MouseDown function");
                return;
            }
        }
        private void PassKeys()
        {
            OnSpecialCommand(new SpecialCommandArgs(MacroAction.ActionType.PassKeys, ""));
        }
        private void Wait(string parameters)
        {
            int waitTime;
            if (int.TryParse(parameters, out waitTime))
            {
                Thread.Sleep(waitTime);
            }
            else
            {
                MessageBox.Show("couldn't parse wait time for wait command + " + parameters);
            }
        }
        private void TypeKey(string whichKey)
        {
            KeyDown(whichKey);
            KeyUp(whichKey);
        }
        private void RunMacro(string nameOfMacro)
        {
            OnSpecialCommand(new SpecialCommandArgs(MacroAction.ActionType.RunMacro, nameOfMacro));
        }
    }
}
