using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace WindowTabs
{
    class WindowManager
    {
        //variables
        System.Timers.Timer windowUpdateTimer = new System.Timers.Timer();
        public Window[] allWindows = new Window[maxWindows];
        const int maxWindows = 18;
        int currentWindow = 0;
        readonly IntPtr thisProgramHWND;
        IntPtr currentFocusedHWND = IntPtr.Zero;

        //constructor
        public WindowManager(IntPtr formHWND)
        {
            thisProgramHWND = formHWND;
            windowUpdateTimer.Interval = 250;
            windowUpdateTimer.Elapsed += WindowUpdateTimer_Elapsed;
            windowUpdateTimer.Start();
        }
        
        //timers
        private void WindowUpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            for (int i = 0; i < currentWindow; i++)
            {
                if (WinApi.IsWindowVisible(allWindows[i].GetHWND()) == false)
                {
                    RemoveWindow(i);
                }
            }
        }

        //events
        public event EventHandler WindowChanged;
        protected virtual void OnWindowChange(EventArgs e)
        {
            EventHandler handler = WindowChanged;
            if (handler != null) handler(this, e);
        }

        //methods
        public void AddNewWindow()
        {
            const int maxCount = 256;
            StringBuilder stringBuilderWindowName = new StringBuilder(maxCount);
            bool isWindowValid = true;
            bool finishedAddingWindow = false;
            while (!finishedAddingWindow)
            {
                //gets window title and puts it into stringBuilderWindowName

                if (WinApi.GetForegroundWindow() != thisProgramHWND)
                {
                    if (WinApi.GetWindowText(WinApi.GetForegroundWindow(), stringBuilderWindowName, maxCount) > 0)
                    {
                        //WinApi.GetWindowText(WinApi.GetForegroundWindow(), stringBuilderWindowName, maxCount);
                        //make sure they aren't just click on the desktop or the program itself
                        if (stringBuilderWindowName.ToString() != "Program Manager" && stringBuilderWindowName.ToString() != "Cortana")
                        {
                            IntPtr thisWindow = WinApi.FindWindow(null, stringBuilderWindowName.ToString());
                            //check to see if the program is already in list
                            foreach (Window window in allWindows)
                            {
                                if (window != null)
                                {
                                    if (thisWindow == window.GetHWND()) isWindowValid = false;
                                }
                            }
                            if (isWindowValid)
                            {
                                if (currentWindow < maxWindows)
                                {
                                    try
                                    {
                                        allWindows[currentWindow] = new Window(thisWindow);
                                        currentWindow++;
                                        FollowForm();
                                    }
                                    catch (Exception e)
                                    {
                                        //most likely access denied
                                        Console.WriteLine("couldn't add window exception:{0}", e.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Max amount of programs added({0})",maxWindows.ToString());
                                }
                                OnWindowChange(EventArgs.Empty);
                                finishedAddingWindow = true;
                            }
                            else
                            {
                                Console.WriteLine("Already added this program");
                                finishedAddingWindow = true;
                            }
                            //pictureBoxProgram.Image = Icon.ExtractAssociatedIcon(thisProcess.MainModule.FileName).ToBitmap();
                            //Bitmap screenshot = new Bitmap(thisWindowRect.right - thisWindowRect.left, thisWindowRect.bottom - thisWindowRect.top, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            //Graphics g = Graphics.FromImage(screenshot);
                            //g.CopyFromScreen(thisWindowRect.left, thisWindowRect.top, 0, 0, screenshot.Size, CopyPixelOperation.SourceCopy);
                            //pictureBoxProgram.Image = screenshot;
                        }
                    }
                }
            }
        }
        public void AddNewWindow(string className)
        {
            IntPtr theWindowHwnd = WinApi.FindWindow(className, null);
            const int maxCount = 256;
            StringBuilder stringBuilderWindowName = new StringBuilder(maxCount);
            bool isWindowValid = true;
                //gets window title and puts it into stringBuilderWindowName

                if (theWindowHwnd != thisProgramHWND)
                {
                    if (WinApi.GetWindowText(theWindowHwnd, stringBuilderWindowName, maxCount) > 0)
                    {
                        //WinApi.GetWindowText(theWindowHwnd, stringBuilderWindowName, maxCount);
                        //make sure they aren't just click on the desktop or the program itself
                        if (stringBuilderWindowName.ToString() != "Program Manager" && stringBuilderWindowName.ToString() != "Cortana")
                        {
                            IntPtr thisWindow = WinApi.FindWindow(null, stringBuilderWindowName.ToString());
                            //check to see if the program is already in list
                            foreach (Window window in allWindows)
                            {
                                if (window != null)
                                {
                                    if (thisWindow == window.GetHWND()) isWindowValid = false;
                                }
                            }
                            if (isWindowValid)
                            {
                                if (currentWindow < maxWindows)
                                {
                                    try
                                    {
                                        allWindows[currentWindow] = new Window(thisWindow);
                                        currentWindow++;
                                        FollowForm();
                                    }
                                    catch (Exception e)
                                    {
                                        //most likely access denied
                                        Console.WriteLine("couldn't add window exception:{0}", e.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Max amount of programs added({0})", maxWindows.ToString());
                                }
                                OnWindowChange(EventArgs.Empty);
                            }
                            else
                            {
                                Console.WriteLine("Already added this program");
                            }
                            //pictureBoxProgram.Image = Icon.ExtractAssociatedIcon(thisProcess.MainModule.FileName).ToBitmap();
                            //Bitmap screenshot = new Bitmap(thisWindowRect.right - thisWindowRect.left, thisWindowRect.bottom - thisWindowRect.top, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                            //Graphics g = Graphics.FromImage(screenshot);
                            //g.CopyFromScreen(thisWindowRect.left, thisWindowRect.top, 0, 0, screenshot.Size, CopyPixelOperation.SourceCopy);
                            //pictureBoxProgram.Image = screenshot;
                        }
                    }
            }
        }
        public void MakeWindowFocus(int whichWindow)
        {
            //there was a previous window of some sort search for it in the windows list to see if it still exists
            if (currentFocusedHWND != IntPtr.Zero)
            {
                for (int i = 0; i < allWindows.Length; i++)
                {
                    if(allWindows[i] != null)
                    if (allWindows[i].GetHWND() == currentFocusedHWND)
                    {
                        WinApi.SetWindowPos(allWindows[i].GetHWND(), WinApi.InsertAfter.HWND_NOTOPMOST, 0, 0, 0, 0, WinApi.SetWindowPosFlags.SWP_NOSIZE);
                    }
                }
                WinApi.SetWindowPos(allWindows[whichWindow].GetHWND(), WinApi.InsertAfter.HWND_TOPMOST, 0, 0, 0, 0, WinApi.SetWindowPosFlags.SWP_NOSIZE);
                currentFocusedHWND = allWindows[whichWindow].GetHWND();
            }
            //there was never a previous window this is the first window
            else
            {
                WinApi.SetWindowPos(allWindows[whichWindow].GetHWND(), WinApi.InsertAfter.HWND_TOPMOST, 0, 0, 0, 0, WinApi.SetWindowPosFlags.SWP_NOSIZE);
                currentFocusedHWND = allWindows[whichWindow].GetHWND();
            }
            FollowForm();
        }
        public void RemoveWindow(int whichWindow)
        {
            allWindows[whichWindow] = null;
            for (int i = whichWindow; i < (allWindows.Length - 1); i++)
            {
                allWindows[i] = allWindows[i + 1];
            }
            currentWindow--;
            OnWindowChange(EventArgs.Empty);
        }
        public void FollowForm()
        {
            WinApi.RECT thisProgramRect = new WinApi.RECT();
            WinApi.GetWindowRect(thisProgramHWND, out thisProgramRect);
            for (int i = 0; i < allWindows.Length; i++)
            {
                if (allWindows[i] != null)
                    //in this case insert after isn't used
                    WinApi.SetWindowPos(allWindows[i].GetHWND(), WinApi.InsertAfter.HWND_BOTTOM, thisProgramRect.left + 224, thisProgramRect.top + 32, 0, 0, WinApi.SetWindowPosFlags.SWP_NOZORDER | WinApi.SetWindowPosFlags.SWP_NOSIZE);
            }
        }
        void OnWindowClose(object sender, EventArgs e)
        {
            Process processToBeRemoved = ((Process)(sender));
            for (int i = 0; i < allWindows.Length; i++)
            {
                if(allWindows[i] != null) 
                if (processToBeRemoved.Id == allWindows[i].GetProcessID()) RemoveWindow(i);
            }
        }
        public Bitmap[] GetAllImages()
        {
            Bitmap[] allImages = new Bitmap[currentWindow];
            for (int i = 0; i < currentWindow; i++)
            {
                allImages[i] = allWindows[i].GetIcon();
            }
            return allImages;
        }
    }
}