using System;
using System.Text;
using Sys = Cosmos.System;
using ThreeOS.TSystem.VersionUtils;

namespace ThreeOS.TSystem.CrashHandler
{
    internal class CrashManager
    {
        public static void ShowCrashScreen(string errorType, string errorCode)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();

            Console.WriteLine("- SYSTEM CRASH -");
            Console.WriteLine($"ERROR TYPE: {errorType}");
            Console.WriteLine($"ERROR CODE: {errorCode}");
            Console.WriteLine($"ThreeOS BUILD: {VersionInfo.BuildVersion}");
            Console.WriteLine("- SYSTEM STOPPED : PRESS S TO SHUTDOWN -");

            var pressKey = Console.ReadKey(true);
            if(pressKey.Key == ConsoleKey.S)
            {
                Console.WriteLine("- SHUTDOWN PC -");
                Sys.Power.Shutdown();
            } else
            {
                Console.WriteLine("- UNKNOWN KEY -");
            }
        }
    }
}
