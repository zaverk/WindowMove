using System.Diagnostics;
using static windows_move.Mover;

namespace windows_move
{
    public static class WM
    {
        public static Process? ProcessName { get; private set; }

        public static void Main()
        {
            string[] names = new[] { "Spotify", "Telegram", "Discord" };
            var r = Process.GetProcessesByName("Spotify");
            for (int i = 0; i < names.Length; i++)
            {
                foreach (var t in Process.GetProcesses())
                {
                    if (t.MainWindowHandle != IntPtr.Zero && t.ProcessName.Contains(names[i]))
                    {
                        if (i == 0)
                        {
                            ProcessName = t;
                            Move(Process.GetProcessesByName(ProcessName?.ProcessName), 0, -1928, -8, 1936, 1048, 0x0400);
                        }

                        ProcessName = t;
                        Move(Process.GetProcessesByName(ProcessName?.ProcessName), 0, 1912, 165, 1568, 868, 0x0400);
                    }
                    
                }
            }
        }
    }
}
