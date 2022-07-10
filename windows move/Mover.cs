using System.Diagnostics;
using System.Runtime.InteropServices;
using static windows_move.Extern;

namespace windows_move
{
    internal class Mover
    {
        public static void Move(Process[] ProcessName, int HWND, int Left, int Top, int Width, int Height, int wFlags)
        {
            foreach (var process in ProcessName)
            {
                process.WaitForInputIdle();
                if (process.MainWindowHandle != IntPtr.Zero)
                {
                    SetWindowPos(process.MainWindowHandle, HWND, Left, Top, Width, Height, wFlags);
                }
            }
        }
    }
}
