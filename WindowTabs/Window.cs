using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace WindowTabs
{
    class Window
    {
        uint processID;
        IntPtr hwnd;
        Process process;
        Bitmap icon;

        public Window(IntPtr whatWindow)
        {
            hwnd = whatWindow;
            WinApi.GetWindowThreadProcessId(whatWindow, out processID);
            process = Process.GetProcessById((int)processID);
            icon = Icon.ExtractAssociatedIcon(process.MainModule.FileName.ToString()).ToBitmap();
        }

        public string GetWindowName()
        {
            StringBuilder windowName = new StringBuilder(256);
            WinApi.GetWindowText(hwnd, windowName, 256);
            return windowName.ToString();
        }
        public string GetClassName()
        {
            StringBuilder className = new StringBuilder(256);
            WinApi.GetClassName(hwnd, className, 256);
            return className.ToString();
        }
        public string GetProcessName() { return process.ProcessName; }
        public IntPtr GetHWND() { return hwnd; }
        public uint GetProcessID() { return processID; }
        public Bitmap GetIcon() { return icon; }
        public Rectangle GetRect()
        {
            WinApi.RECT thisWindowRect;
            WinApi.GetWindowRect(hwnd, out thisWindowRect);
            Rectangle correctFormat = new Rectangle(thisWindowRect.left, thisWindowRect.top, (thisWindowRect.right - thisWindowRect.left), (thisWindowRect.bottom - thisWindowRect.top));
            return correctFormat;
        }
    }
}
