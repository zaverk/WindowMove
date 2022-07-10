using System.Diagnostics;
using System.Runtime.InteropServices;
using static windows_move.Mover;

namespace windows_move
{
    public static class WM
    {
        public static Process? ProcessName { get; private set; }

        public static void Main()
        {
            string[] names = new[] { "Spotify", "Telegram", "Discord" };
            Process[][] result = new Process[3][];
            for (int i = 0; i < names.Length; i++)
            {
                result[i] = Process.GetProcessesByName(names[i]);
            }

            foreach (var r in result)
            {
                foreach (var p in r)
                {
                    if (p.ProcessName == "Spotify")
                    {
                        Move(r, 0, -1928, -8, 1936, 1048, 0x0400);
                    }

                    if (p.ProcessName == "Telegram")
                    {
                        Move(r, 0, 1912, 165, 1568, 868, 0x0400);
                    }

                    if (p.ProcessName == "Discord")
                    {
                        Move(r, 0, 1912, 165, 1568, 868, 0x0400);
                    }
                }
            }
        }
    }
}
