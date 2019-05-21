using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using Newtonsoft.Json;


namespace WindowTabs
{
    public partial class Form1 : Form
    {
        GlobalInput globalInput;
        WindowManager windowManager;
        MacroManager macroManager;
        FormEditMacro formEditWindow = new FormEditMacro();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            globalInput = new GlobalInput();
            macroManager = new MacroManager();
            //this.TopMost = true;
            if (Directory.Exists(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WindowTabs\"))
            {
                if (File.Exists(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WindowTabs\macros.txt"))
                {
                    macroManager = JsonConvert.DeserializeObject<MacroManager>(File.ReadAllText(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WindowTabs\macros.txt"));
                    if (macroManager == null)
                    {
                        MessageBox.Show("couldn't load config file will make a new macros save file \n (a copy of the old macros save file will be left at "
                                        + @Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"WindowTabs\broken.txt" + "\n" + " a new macros save file will be saved when the program is closed");
                        macroManager = new MacroManager();
                    }
                }
                else macroManager = new MacroManager();
            }
            else
            {
                Directory.CreateDirectory(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WindowTabs\");
                macroManager = new MacroManager();
            }
            windowManager = new WindowManager(this.Handle);
            windowManager.WindowChanged += OnWindowChanged;
            macroList.OnMacroEdit += OnMacroEdit;
            macroManager.MacroManagerListChange += OnMacroManagerListChange;
            List<Macro> globalMacros = macroManager.FindByInputLevel(Macro.InputLevel.global);
            globalInput.currentMacros = globalMacros.ToArray();
            foreach (Macro macro in globalMacros)
            {
                macroList.Add(macro.macroName, macro.HotkeyString());
            }
            //macroManager.Add(new Macro());
            //macroManager.Add(testMacro);
            //macroManager.Add(testMacro);
            //macroManager.Add(testMacro);
            //macroManager.Add(testMacro);
            //macroManager.Add(testMacro);
            //macroManager.Add(testMacro);

            //string jsonParsed = JsonConvert.SerializeObject(testMacro,Formatting.Indented);
            //File.WriteAllText(@"C:\Users\Tyson Shepherd\Desktop\testJSON.txt", jsonParsed);
            //Macro testMacro = new Macro();
            //testMacro = JsonConvert.DeserializeObject<Macro>(File.ReadAllText(@"C:\Users\Tyson Shepherd\Desktop\testJSON.txt"));
            //uint initialStyle = WinApi.GetWindowLongPtr(panel1.Handle, -20);
            //WinApi.SetWindowLong(panel1.Handle, -20, initialStyle | 0x80000 | 0x20);
        }

        private void OnMacroManagerListChange(object sender,MacroManager.MacroListChangeArgs e)
        {
            switch (e.TypeOfChange)
            {
                case MacroManager.TypeOfChange.add:
                    macroList.Add(e.Macro.macroName, e.Macro.HotkeyString());
                    break;
                case MacroManager.TypeOfChange.remove:
                    macroList.Remove(e.Macro.macroName);
                    break;
                case MacroManager.TypeOfChange.change:
                    macroList.Change(e.Macro.macroName, e.changeMacroNew.macroName, e.Macro.HotkeyString(), e.changeMacroNew.HotkeyString());
                    break;
                default:
                    break;
            }
            ListView.SelectedIndexCollection indexCollection = listViewWindowTabs.SelectedIndices;
            List<Macro> applicationMacros;
            List<Macro> globalMacros;
            if (indexCollection.Count > 0)
            {
                applicationMacros = macroManager.FindByProcessName(windowManager.allWindows[indexCollection[0]].GetProcessName());
                if (applicationMacros.Count > 0)
                {
                    for (int i = 0; i < applicationMacros.Count; i++)
                    {
                        if (applicationMacros[i].inputLevel == Macro.InputLevel.global) applicationMacros.RemoveAt(i);
                    }
                }
                globalMacros = macroManager.FindByInputLevel(Macro.InputLevel.global);
                globalInput.currentMacros = globalMacros.Concat(applicationMacros).ToArray();
            }
            else
            {
                globalMacros = macroManager.FindByInputLevel(Macro.InputLevel.global);
                globalInput.currentMacros = macroManager.FindByInputLevel(Macro.InputLevel.global).ToArray();
            }
        }

        private void OnMacroEdit(object sender, MacroList.MacroEditArgs e)
        {
            List<Macro> macros = macroManager.FindByName(e.MacroName);
            if (macros.Count <= 0)
            {
                MessageBox.Show("couldn't find that macro by it's name");
                return;
            }
            if (macros.Count <= 0)
            {
            MessageBox.Show("can't edit");
            }
            macroManager.Edit(macros[0]);
        }

        private void BtnAddWindow_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerAddWindow.IsBusy == false)
                backgroundWorkerAddWindow.RunWorkerAsync(this.Handle);
        }

        bool mouseDown = false;
        Point lastLocation;
        private void PnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void PnlTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void PnlTopBar_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }
        private void PnlTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                windowManager.FollowForm();
            }
        }


        private void BackgroundWorkerAddWindow_DoWork(object sender, DoWorkEventArgs e)
        {
            windowManager.AddNewWindow();
        }

        private void BackgroundWorkerAddWindow_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            imageListCurrentPrograms.Images.Clear();
            imageListCurrentPrograms.Images.AddRange(windowManager.GetAllImages());
            listViewWindowTabs.SmallImageList = imageListCurrentPrograms;
            listViewWindowTabs.Items.Clear();
            for (int i = 0; i < imageListCurrentPrograms.Images.Count; i++)
            {
                listViewWindowTabs.Items.Add(new ListViewItem("", i));
            }
        }

        private void ListViewWindowTabs_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            lblCurrentWindowName.Text = windowManager.allWindows[e.ItemIndex].GetWindowName();
            lblWindowHandle.Text = windowManager.allWindows[e.ItemIndex].GetHWND().ToString();
            lblCurrentProcessID.Text = windowManager.allWindows[e.ItemIndex].GetProcessID().ToString();
            windowManager.MakeWindowFocus(e.ItemIndex);
            ListView.SelectedIndexCollection indexCollection = listViewWindowTabs.SelectedIndices;
            List<Macro> applicationMacros;
            List<Macro> globalMacros;
            if (indexCollection.Count > 0)
            {
                applicationMacros = macroManager.FindByProcessName(windowManager.allWindows[indexCollection[0]].GetProcessName());
                if (applicationMacros != null)
                {
                    if (applicationMacros.Count > 0)
                    {
                        for (int i = 0; i < applicationMacros.Count; i++)
                        {
                            if (applicationMacros[i].inputLevel == Macro.InputLevel.global)
                            {
                                applicationMacros.RemoveAt(i);
                                i--;
                            } 
                        }
                    }
                }
                globalMacros = macroManager.FindByInputLevel(Macro.InputLevel.global);
                if (globalMacros == null && applicationMacros == null) globalInput.currentMacros = new Macro[0];
                else if (globalMacros == null && applicationMacros != null) globalInput.currentMacros = applicationMacros.ToArray();
                else if (globalMacros != null && applicationMacros == null) globalInput.currentMacros = globalMacros.ToArray();
                else globalInput.currentMacros = globalMacros.Concat(applicationMacros).ToArray();
                if (globalInput.currentMacros == null) macroList.Clear();
                else if (globalInput.currentMacros.Count() == 0) macroList.Clear();

            }
        }

        void OnWindowChanged(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate 
            {
                imageListCurrentPrograms.Images.Clear();
                imageListCurrentPrograms.Images.AddRange(windowManager.GetAllImages());
                listViewWindowTabs.SmallImageList = imageListCurrentPrograms;
                listViewWindowTabs.Items.Clear();
                for (int i = 0; i < imageListCurrentPrograms.Images.Count; i++)
                {
                    listViewWindowTabs.Items.Add(new ListViewItem("", i));
                }
            });
        }

        private void macroListItem_EditButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("yeet");
        }

        private void macroListItem_EditButtonClick(object sender, MacroListItem.MacroEditButtonArgs e)
        {

        }

        private void BtnAddMacro_Click(object sender, EventArgs e)
        {
            macroManager.Add(new Macro());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(@Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\WindowTabs\macros.txt", JsonConvert.SerializeObject(macroManager, Formatting.Indented));
        }

        /*
private void btnSetWindowPos_Click(object sender, EventArgs e)
{
windowManager.MakeWindowFocus(listViewWindowTabs.SelectedItems[0].Index);
ClickOnWindow((IntPtr)(393816), (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(523, 657));
ClickOnWindow((IntPtr)(393816), (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(523, 657));
typeOnWindow((IntPtr)(393816), "YEET");
WinApi.ShowWindow((IntPtr)int.Parse(lblWindowHandle.Text.ToString()), 5);
}
*/


    }
}
