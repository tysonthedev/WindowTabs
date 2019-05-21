using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowTabs
{
    [Serializable]
    class Macro
    {
        public string macroName;
        public string macroProcessName;
        public string macroClassPath;
        public List<int> hotkey;
        public bool directInput;
        public bool currentlyExecuting { get; private set; } = false;
        public InputLevel inputLevel;
        public List<MacroAction> macroActions;
        public MacroExecuter macroExecuter;

        //macro name will be the txt file name
        //example of macroProcessName:notepad.exe
        //example of macroClassPath: SDL_app>CefBrowserWindow>Chrome_WidgetWin_0

        public Macro()
        {
            //hotkey = new List<int>() { 84, 69, 83, 84 };
            hotkey = new List<int>();
            macroActions = new List<MacroAction>();
            macroName = "New Macro";
            macroExecuter = new MacroExecuter(this);
            macroExecuter.IsCurrentlyExecuting += OnExecutionChange;
        }
        public static Macro DeepCopy(Macro macro)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, macro);
            stream.Seek(0, SeekOrigin.Begin);
            Macro result = (Macro)formatter.Deserialize(stream);
            result.macroExecuter.worker = new System.ComponentModel.BackgroundWorker();
            result.macroExecuter.worker.DoWork += result.macroExecuter.ExecuteMacro;
            result.macroExecuter.worker.RunWorkerCompleted += result.macroExecuter.Worker_RunWorkerCompleted;
            stream.Close();
            return result;
        }
        private void OnExecutionChange(object sender, MacroExecuter.IsExecutingArgs e)
        {
            currentlyExecuting = e.isExecuting;
        }
        public override bool Equals(object whichMacro)
        {
            if (whichMacro.GetType() != typeof(Macro)) return false;
            if (JsonConvert.SerializeObject(whichMacro) == JsonConvert.SerializeObject(this)) return true;
            else return false;
        }
        public override int GetHashCode()
        {
            string nameProcessClass = macroName + macroProcessName + macroClassPath;
            //MessageBox.Show("name process class: " + nameProcessClass.GetHashCode().ToString());
            //MessageBox.Show("macro actions: " + macroActions.GetHashCode().ToString());
            //MessageBox.Show("default hash: " + base.GetHashCode().ToString());
            return base.GetHashCode();
        }
        public string HotkeyString()
        {
            Keys[] keyCombo = new Keys[hotkey.Count];
            string keyComboString = "";

            if (hotkey.Count > 0)
            {
                for (int i = 0; i < hotkey.Count; i++)
                {
                    keyCombo[i] = (Keys)hotkey[i];
                }
                keyComboString = keyCombo[0].ToString();
                for (int i = 1; i < keyCombo.Length; i++)
                {
                    keyComboString += "+" + keyCombo[i].ToString();
                }
            }
            return keyComboString;
        }
        public enum InputLevel
        {
            global,
            windowTabs,
            application
        }
        public Keys[] hotkeyAsKeys()
        {
            int[] hotkeysInt = hotkey.ToArray();
            if (hotkeysInt == null) return null;
            else if (hotkeysInt.Length <= 0) return null;

            Keys[] keys = new Keys[hotkeysInt.Length];

            for (int i = 0; i < hotkeysInt.Length; i++)
            {
                keys[i] = (Keys)(hotkeysInt[i]);
            }
            return keys;
        }
        public Macro(string name, string processName, string classPath, InputLevel _inputLevel, List<int> _hotkey, List<MacroAction> actions)
        {
            macroName = name;
            macroProcessName = processName;
            macroClassPath = classPath;
            macroActions = actions;
            hotkey = _hotkey;
            inputLevel = _inputLevel;
            macroExecuter = new MacroExecuter(this);
            macroExecuter.IsCurrentlyExecuting += OnExecutionChange;
        }
    }
}