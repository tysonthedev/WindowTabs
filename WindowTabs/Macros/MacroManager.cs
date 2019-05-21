using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowTabs
{
    class MacroManager
    {
        public List<Macro> allMacros { get; private set; }

        public event EventHandler<MacroListChangeArgs> MacroManagerListChange;

        public MacroManager()
        {
            allMacros = new List<Macro>();
        }

        public void Add(Macro whatMacro)
        {
            allMacros.Add(whatMacro);
            MacroListChanged(new MacroListChangeArgs(whatMacro,null,TypeOfChange.add));
        }
        public void Remove(Macro whatMacro)
        {
            if(allMacros.Remove(whatMacro)) MacroListChanged(new MacroListChangeArgs(whatMacro, null,TypeOfChange.remove));
        }
        public void Change(Macro oldMacro, Macro newMacro)
        {
            if (allMacros.Count <= 0) return;
            for (int i = 0; i < allMacros.Count; i++)
            {
                if (allMacros[i].Equals(oldMacro))
                {
                    allMacros[i] = Macro.DeepCopy(newMacro);
                    MacroListChanged(new MacroListChangeArgs(oldMacro, newMacro, TypeOfChange.change));
                    return;
                }
            }
        }

        public void Edit(Macro macroToEdit)
        {
            FormEditMacro editWindow = new FormEditMacro();
            editWindow.SetMacro(macroToEdit);
            System.Windows.Forms.DialogResult result = editWindow.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Change(editWindow.GetMacro(FormEditMacro.MacroType.original), editWindow.GetMacro(FormEditMacro.MacroType.edited));
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                //delete macro here
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("something went wrong with the edit window no changes have been made");
            }
        }

        public List<Macro> FindByInputLevel(Macro.InputLevel inputLevel)
        {
            if (allMacros.Count <= 0) return null;
            List<Macro> thisList = new List<Macro>();
            foreach (Macro macro in allMacros)
            {
                if (macro.inputLevel == inputLevel)
                {
                    thisList.Add(macro);
                }
            }
            return thisList;
        }
        public List<Macro> FindByProcessName(string processName)
        {
            if (allMacros.Count <= 0) return null;
            List<Macro> thisList = new List<Macro>();
            foreach (Macro macro in allMacros)
            {
                if (macro.macroProcessName == processName)
                {
                    thisList.Add(macro);
                }
            }
            return thisList;
        }
        public List<Macro> FindByName(string nameOfMacro)
        {
            if (allMacros.Count <= 0) return null;
            List<Macro> thisList = new List<Macro>();
            foreach (Macro macro in allMacros)
            {
                if (macro.macroName == nameOfMacro)
                {
                    thisList.Add(macro);
                }
            }
            //if it gets to this point then there is no macro with that name
            return thisList;
        }
        public List<Macro> FindByHotKey(string hotKeyString)
        {
            if (allMacros.Count <= 0) return null;
            List<Macro> thisList = new List<Macro>();
            foreach (Macro macro in allMacros)
            {
                if (macro.HotkeyString() == hotKeyString)
                {
                    thisList.Add(macro);
                }
            }
            //if it gets to this point then there is no macro with that hotkey
            return thisList;
        }

        protected virtual void MacroListChanged(MacroListChangeArgs e)
        {
            EventHandler<MacroListChangeArgs> handler = MacroManagerListChange;
            if (handler != null) handler(this, e);
        }

        public enum TypeOfChange
        {
            add,
            remove,
            change
        }
        public class MacroListChangeArgs : EventArgs
        {
            public TypeOfChange TypeOfChange { get; }
            public Macro Macro { get; }
            public Macro changeMacroNew { get; }
            public MacroListChangeArgs(Macro macro, Macro newMacro ,TypeOfChange typeOfChange)
            {
                Macro = macro;
                changeMacroNew = newMacro;
                TypeOfChange = typeOfChange;
            }
        }
    }
}
