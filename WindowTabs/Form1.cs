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
            windowManager = new WindowManager(this.Handle);
            windowManager.WindowChanged += OnWindowChanged;
            macroList.OnMacroEdit += OnMacroEdit;
            macroManager.MacroManagerListChange += OnMacroManagerListChange;
            Macro testMacro = new Macro("Click On Next Button", "vivaldi", "Chrome_WidgetWin_1", Macro.InputLevel.application, new List<int>(),
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
                    new MacroAction(MacroAction.ActionType.MouseDown,"Left,1025,978,"),
                    new MacroAction(MacroAction.ActionType.MouseUp,"Left,1025,978,"),
                    //new MacroAction(MacroAction.ActionType.KeyDown,"A")
                });
            //MacroExecuter test = new MacroExecuter(testMacro);
            //328834


            macroManager.Add(testMacro);
            macroManager.Add(testMacro);
            macroManager.Add(testMacro);
            macroManager.Add(testMacro);
            macroManager.Add(testMacro);
            macroManager.Add(testMacro);
            
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
            //windowManager.AddNewWindow(this.Handle);

            //vivaldi next song
            //1048,984
            //ClickOnWindow((IntPtr)(591176), (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(1048, 984));
            //ClickOnWindow((IntPtr)(591176), (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(1048, 984));
            //typeOnWindow((IntPtr)(3867712), "TEST");
            //notepad++ (not working)
            //ClickOnWindow((IntPtr)(30081600), (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(400, 300));
            //ClickOnWindow((IntPtr)(30081600), (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(400, 300));
            //typeOnWindow((IntPtr)(30081600), "TEST");
            //slack
            //ClickOnWindow((IntPtr)(2558992), (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(460, 656));
            //ClickOnWindow((IntPtr)(2558992), (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(460, 656));
            //typeOnWindow((IntPtr)(2558992), "TEST");
            //discord
            //ClickOnWindow((IntPtr)(393816), (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(523, 657));
            //ClickOnWindow((IntPtr)(393816), (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(523, 657));
            //typeOnWindow((IntPtr)(393816), "YEET");
            //Keys a = (Keys)Enum.Parse(typeof(Keys), "A");
            //WinApi.SendMessage(notepad.hwnd, 0x000c, IntPtr.Zero, new StringBuilder("yeetasdf"));
            //WinApi.PostMessage(notepad.hwnd, 0x000c, a, IntPtr.Zero);
            //steam
            //IntPtr steamWindow = WinApi.FindWindow("SDL_app", null);
            //steamWindow = WinApi.FindWindowEx(steamWindow, IntPtr.Zero, "CefBrowserWindow", null);
            //IntPtr correctWindow = WinApi.FindWindowEx(steamWindow, IntPtr.Zero, "Chrome_WidgetWin_0", null);
            //MessageBox.Show(correctWindow.ToString());
            //ClickOnWindow(correctWindow, (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(150, 613));
            //ClickOnWindow(correctWindow, (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(150, 613));
            //typeOnWindow(correctWindow, "TEST");
            //ClickOnWindow((IntPtr)(132848), (uint)WinApi.WParamMouse.WM_LBUTTONDOWN, new Point(150, 613));
            //    ClickOnWindow((IntPtr)(132848), (uint)WinApi.WParamMouse.WM_LBUTTONUP, new Point(150, 613));
            //    typeOnWindow((IntPtr)(132848), "TEST");
            /*
            List<IntPtr> allWindows = WinApi.GetAllChildHandles((IntPtr)(393816));
            foreach (IntPtr handle in allWindows)
            {
                Console.WriteLine(handle.ToString());
                
            }
            */
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
