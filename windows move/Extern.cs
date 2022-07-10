using System.Runtime.InteropServices;

namespace windows_move
{
    internal class Extern
    {
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        public static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);
    }
}
