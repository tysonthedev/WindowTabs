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
    public partial class MacroList : UserControl
    {

        public event EventHandler<MacroEditArgs> OnMacroEdit;

        List<MacroListItem> macroItems;
        Timer timerScroll;


        public MacroList()
        {
            InitializeComponent();
            this.MouseWheel += OnListScroll;
            macroItems = new List<MacroListItem>();
            timerScroll = new Timer();
            timerScroll.Interval = 1;
            timerScroll.Tick += TimerScroll_Tick;
            timerScroll.Start();
        }

        private void MacroList_EditButtonClick(object sender,MacroListItem.MacroEditButtonArgs e)
        {
            EventHandler<MacroEditArgs> MacroEdit = OnMacroEdit;
            if (MacroEdit != null) OnMacroEdit(this,new MacroEditArgs(e.MacroName));
        }

        public void Clear()
        {
            foreach (MacroListItem item in macroItems)
            {
                item.Dispose();
            }
            macroItems.Clear();
            SetListPos(TopOfListPos());
        }

        public void Remove(string macroName)
        {
            foreach (MacroListItem item in macroItems)
            {
                if (item.MacroName == macroName)
                {
                    macroItems.Remove(item);
                    item.Dispose();
                    SetListPos(TopOfListPos());
                    return;
                }
            }
            Console.WriteLine("couldn't remove list item");
        }

        public void Add(string macroName, string macroHotKey)
        {
            MacroListItem newItem = new MacroListItem(macroName, macroHotKey);
            newItem.Parent = this;
            newItem.MouseWheel += OnListScroll;
            newItem.EditButtonClick += MacroList_EditButtonClick;
            newItem.Location = BottomOfListPos();
            macroItems.Add(newItem);
        }
        public void Change(string macroName, string newName, string hotkey, string newHotkey)
        {
            if (macroItems.Count <= 0) return;
            foreach (MacroListItem item in macroItems)
            {
                if (item.MacroName == macroName)
                {
                    item.MacroName = newName;
                    item.HotKey = newHotkey;
                    return;
                }
            }
        }
        int listScrollAmount = 0;
        int scrollPositionStep = SystemInformation.MouseWheelScrollLines * 4;

        Point TopOfListPos()
        {
            if (macroItems.Count <= 0) return new Point(0,5);
            else return new Point(macroItems[0].Location.X, macroItems[0].Location.Y);
        }
        Point BottomOfListPos()
        {
            if (macroItems.Count <= 0) return new Point(0,5);
            else return new Point(macroItems[macroItems.Count - 1].Location.X, macroItems[macroItems.Count - 1].Location.Y + macroItems[macroItems.Count - 1].Height + 5);
        }
        bool KeepInBoundaries(int stepAmount)
        {
            if (BottomOfListPos().Y - TopOfListPos().Y <= this.Height)
            {
                listScrollAmount = 0;
                SetListPos(new Point(0, 5));
                return true;
            }
            if (stepAmount >= 0)
            {
                if (TopOfListPos().Y + stepAmount >= 0)
                {
                    listScrollAmount = 0;
                    SetListPos(new Point(0, 5));
                    return true;
                }
                return false;
            }
            else
            {
                if (BottomOfListPos().Y + stepAmount <= this.Height)
                {
                    listScrollAmount = 0;
                    SetListPos(new Point(0, -((BottomOfListPos().Y - TopOfListPos().Y) - this.Height)));
                    return true;
                }
                return false;
            }
        }
        void SetListPos(Point whatPoint)
        {
            if (macroItems.Count <= 0) return; 
            for (int i = 0; i < macroItems.Count; i++)
            {
                macroItems[i].Location = new Point(whatPoint.X, (i * macroItems[i].Height + i * 5) + whatPoint.Y);
            }
        }
        private void TimerScroll_Tick(object sender, EventArgs e)
        {
            if (Math.Abs(listScrollAmount) - Math.Abs(scrollPositionStep) < Math.Abs(scrollPositionStep)) { listScrollAmount = 0; }
            if (listScrollAmount == 0) return;
            //scroll down
            if (listScrollAmount < 0)
            {
                if (KeepInBoundaries(-scrollPositionStep)) return;
                SetListPos(new Point(TopOfListPos().X, TopOfListPos().Y - scrollPositionStep));
                listScrollAmount += scrollPositionStep;
            }
            //scroll up
            else if (listScrollAmount > 0)
            {
                if (KeepInBoundaries(scrollPositionStep)) return;
                SetListPos(new Point(TopOfListPos().X, TopOfListPos().Y + scrollPositionStep));
                listScrollAmount -= scrollPositionStep;
            }
        }
        private void OnListScroll(object sender, MouseEventArgs e)
        {
            if (macroItems.Count <= 0) return;
            int scrollDistance = e.Delta/120 * SystemInformation.MouseWheelScrollLines * macroItems[0].Height;

            if (macroItems.Count <= 0) return;
                listScrollAmount += scrollDistance;
        }

        public class MacroEditArgs : EventArgs
        {
            public string MacroName { get; }

            public MacroEditArgs(string macroName)
            {
                MacroName = macroName;
            }
        }
    }
}
