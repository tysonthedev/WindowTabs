using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowTabs
{
    public partial class MacroListItem : UserControl
    {
        [Description("Hotkey"), Category("Data")]
        public string HotKey
        {
            get { return lblHotkey.Text; }
            set { lblHotkey.Text = value; }
        }
        public string MacroName
        {
            get { return lblNameOfMacro.Text; }
            set { lblNameOfMacro.Text = value; }
        }
        public event EventHandler<MacroEditButtonArgs> EditButtonClick;
        public MacroListItem()
        {
            InitializeComponent();
            btnEditMacro.Click += OnEditButtonClick;
        }
        public MacroListItem(string name, string hotkey)
        {
            InitializeComponent();
            btnEditMacro.Click += OnEditButtonClick;
            MacroName = name;
            HotKey = hotkey;
        }
        //sender becomes the name of the macro
        private void OnEditButtonClick(object sender, EventArgs e)
        {
            EventHandler<MacroEditButtonArgs> handler = EditButtonClick;
            if (handler != null) handler(this, new MacroEditButtonArgs(MacroName));
        }

        public class MacroEditButtonArgs : EventArgs
        {
            public string MacroName { get; }

            public MacroEditButtonArgs(string name)
            {
                MacroName = name;
            }
        }
    }
}
