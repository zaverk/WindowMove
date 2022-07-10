using System.Diagnostics;
using static windows_move.Mover;

namespace windows_move
{
    public static class WM
    {
        public static Process? ProcessName { get; private set; }

        public static void Main()
        {
            string[] names = new[] { "Spotify", "Telegram", "Discord", "Joxi" };
            var r = Process.GetProcessesByName("Joxi");
            for (int i = 0; i < names.Length; i++)
            {
                foreach (var t in Process.GetProcesses())
                {
                    if (t.MainWindowHandle != IntPtr.Zero && t.ProcessName.Contains(names[i]))
                    {
                        if (names[i] == "Spotify")
                        {
                            ProcessName = t;
                            Move(Process.GetProcessesByName(ProcessName?.ProcessName), 0, -1919, 1, 1918, 1030, 0x0400);
                        }

                        if (names[i] == "Telegram")
                        {
                            ProcessName = t;
                            Move(Process.GetProcessesByName(ProcessName?.ProcessName), 0, 1920, 173, 1552, 852, 0x0400);
                        }

                        if (names[i] == "Discord")
                        {
                            ProcessName = t;
                            Move(Process.GetProcessesByName(ProcessName?.ProcessName), 0, 1921, 174, 1550, 850, 0x0400);
                        }

                        if (names[i] == "Joxi")
                        {
                            ProcessName = t;
                            Move(Process.GetProcessesByName(ProcessName?.ProcessName), 0, 1629, 682, 301, 360, 0x0080);
                        }
                        
                    }
                    
                }
            }
        }
    }
}
