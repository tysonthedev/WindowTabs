using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;

namespace WindowTabs
{
    class GlobalInput
    {
        KeyboardHook keyboardHook;
        public GlobalInput()
        {
            keyboardHook = new KeyboardHook(KeyboardHook.Parameters.PassAllKeysToNextApp);
            keyboardHook.KeyIntercepted += KeyIntercepted;
        }
        
        bool firstTime = true;
        IntPtr discordWindow = IntPtr.Zero;






        Macro rightMacro = new Macro("Click On Next Button", "vivaldi", "Chrome_WidgetWin_1", Macro.InputLevel.application, new List<int>(),
        //MouseClick,< left(0) - right(1) - middle(2) >,< xpos >,< ypos >,< image path >
        ////ClickOnWindow((IntPtr)(393816), (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(523, 657));
        //ClickOnWindow((IntPtr)(393816), (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(523, 657));
        //typeOnWindow((IntPtr)(393816), "YEET");
        new List<MacroAction>()
        {
                    //new MacroAction(MacroAction.ActionType.KeyDown, "A"),
                    //new MacroAction(MacroAction.ActionType.KeyUp, "B"),
                    //new MacroAction(MacroAction.ActionType.TypeKey,"C"),
                    //new MacroAction(MacroAction.ActionType.KeyDown,"D"),
                    //new MacroAction(MacroAction.ActionType.KeyDown,"A")
                    new MacroAction(MacroAction.ActionType.TypeKey,"Right"),
                    //new MacroAction(MacroAction.ActionType.MouseDown,"Left,1032,978,"),
                    //new MacroAction(MacroAction.ActionType.MouseUp,"Left,1032,978,"),
        //new MacroAction(MacroAction.ActionType.KeyDown,"A")
    });
        Macro leftMacro = new Macro("Click On Next Button", "vivaldi", "Chrome_WidgetWin_1", Macro.InputLevel.application, new List<int>(),
//MouseClick,< left(0) - right(1) - middle(2) >,< xpos >,< ypos >,< image path >
////ClickOnWindow((IntPtr)(393816), (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(523, 657));
//ClickOnWindow((IntPtr)(393816), (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(523, 657));
//typeOnWindow((IntPtr)(393816), "YEET");
new List<MacroAction>()
{
                    //new MacroAction(MacroAction.ActionType.KeyDown, "A"),
                    //new MacroAction(MacroAction.ActionType.KeyUp, "B"),
                    //new MacroAction(MacroAction.ActionType.TypeKey,"C"),
                    //new MacroAction(MacroAction.ActionType.KeyDown,"D"),
                    //new MacroAction(MacroAction.ActionType.KeyDown,"A")
                    new MacroAction(MacroAction.ActionType.TypeKey,"Left"),
                    //new MacroAction(MacroAction.ActionType.MouseDown,"Left,897,978,"),
                    //new MacroAction(MacroAction.ActionType.MouseUp,"Left,897,978,"),
    //new MacroAction(MacroAction.ActionType.KeyDown,"A")
});




        List<Keys> currentlyPressedOrder = new List<Keys>();
        private void KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            //use Enum.TryParse to get the key combo from a string
            //KeyboardKeyInfo.GetKeyState(Keys.NumPad4).IsPressed
            //use the above line to test if that key is down
            //if not then remove it from the list of the keys that are down
            //use this list to send to MacroManager and find any macros that have that set of hotkeys
            //if there is one then execute that macro
            Keys currentKey;
            Enum.TryParse<Keys>(e.KeyName, out currentKey);
            if (currentlyPressedOrder.Count > 0)
            {
                for (int i = 0; i < currentlyPressedOrder.Count; i++)
                {
                    if (!KeyboardKeyInfo.GetKeyState(currentlyPressedOrder[i]).IsPressed) currentlyPressedOrder.RemoveAt(i);
                }
            }
            if (!currentlyPressedOrder.Contains(currentKey))
            {
                currentlyPressedOrder.Add(currentKey);
                if (currentlyPressedOrder.Contains(Keys.NumPad4))
                {
                    MacroExecuter yeet = new MacroExecuter(leftMacro);
                }
                /*
                if (KeyboardKeyInfo.GetKeyState(Keys.NumPad4).IsPressed)
                {
                    MacroExecuter yeet = new MacroExecuter(leftMacro);
                }
                */
                if (currentlyPressedOrder.Contains(Keys.NumPad6))
                {
                    MacroExecuter yeet = new MacroExecuter(rightMacro);
                }
                /*
                if (KeyboardKeyInfo.GetKeyState(Keys.NumPad6).IsPressed)
                {
                    MacroExecuter yeet = new MacroExecuter(rightMacro);
                }
                */
            }
            //KeyboardKeyInfo.GetKeyState(currentKey).IsPressed;

            //KeyboardKeyInfo.GetKeyState(Keys.NumPad4).IsPressed
            //Keyboard.IsKeyDown(Key.NumPad4);
            //use these to time keyboard stuff on keydown
            //System.Windows.Forms.SystemInformation.KeyboardDelay44466;
            //System.Windows.Forms.SystemInformation.KeyboardSpeed;
            if (e == null) return;
            if (firstTime == true)
            {
                //topWindow = WinApi.FindWindow("SDL_app", null);
                //steamWindow = WinApi.FindWindow("SDL_app", null);
                //steamWindow = WinApi.FindWindowEx(steamWindow, IntPtr.Zero, "CefBrowserWindow", null);
                //steamWindow = WinApi.FindWindowEx(steamWindow, IntPtr.Zero, "Chrome_WidgetWin_0", null);
                //discordWindow = WinApi.FindWindow(null, @"@HeroBot - Discord");
                //ClickOnWindow(discordWindow, (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(495, 655));
                //ClickOnWindow(discordWindow, (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(495, 655));
                //slack temp
                //ClickOnWindow(correctWindow, (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(483, 654));
                //492, 655
                firstTime = false;
            }

            //MessageBox.Show(correctWindow.ToString());
            /*
            WinApi.WParamMouse tempLDOWN;
            WinApi.WParamMouse tempLUP;
            Enum.TryParse("WM_LBUTTONUP", out tempLUP);
            Enum.TryParse("WM_LBUTTONDOWN", out tempLDOWN);
            ClickOnWindow(correctWindow, (uint)tempLDOWN, new Point(150, 613));
            ClickOnWindow(correctWindow, (uint)tempLUP, new Point(150, 613));
            */
            //ClickOnWindow(correctWindow, (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(150, 613));
            //ClickOnWindow(correctWindow, (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(150, 613));
            //TypeOnWindow(correctWindow, "TEST");
            //if (WinApi.GetForegroundWindow() != topWindow)
            //TypeOnWindow(discordWindow, e.KeyCode);
        }

        void TypeOnWindow(IntPtr hwnd, int keycode)
        {
                Keys whichKey = (Keys)Enum.Parse(typeof(Keys), keycode.ToString());
                uint scanCode = WinApi.MapVirtualKey((uint)whichKey, 0);
                uint lParam = (0x00000001 | (scanCode << 16));
                WinApi.PostMessage(hwnd, (int)WinApi.KeyAction.WM_KEYDOWN, Convert.ToInt32(whichKey), (IntPtr)(lParam));
        }

        void TypeOnWindow(IntPtr hwnd, string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Keys whichKey = (Keys)Enum.Parse(typeof(Keys), message[i].ToString());
                uint scanCode = WinApi.MapVirtualKey((uint)whichKey, 0);
                uint lParam = (0x00000001 | (scanCode << 16));
                WinApi.PostMessage(hwnd, (int)WinApi.KeyAction.WM_KEYDOWN, Convert.ToInt32(whichKey), (IntPtr)(lParam));
            }
            //MessageBox.Show("done");
            //WinApi.PostMessage(hwnd, (int)WinApi.KeyAction.WM_KEYDOWN, Convert.ToInt32(Keys.Enter), 0);
        }
        void ClickOnWindow(IntPtr hwnd, uint message, Point whereToClick)
        {
            WinApi.PostMessage(hwnd, message, 0, WinApi.LPARAMMOUSECOORDS(whereToClick.X, whereToClick.Y));
        }
    }

    
}
