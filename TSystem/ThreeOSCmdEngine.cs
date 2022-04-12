using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using ThreeOS.TSystem.ConsoleTools;
using ThreeOS.TSystem.ThreeScript;
using ThreeOS.TSystem.VersionUtils;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace ThreeOS.TSystem.CMDManager {
    
    internal class TCmdManager {

        public static void HelpCMD() {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("| sysinfo    | Show infos about the ThreeOS build   |");
            Console.WriteLine("| clear      | Clear the Console                    |");
            Console.WriteLine("| shutdown   | Shut down the PC                     |");
            Console.WriteLine("| restart    | Restart the PC                       |");
            Console.WriteLine("| cd         | Change the Current dir               |");
            Console.WriteLine("| ls         | List all files in a dir              |");
            Console.WriteLine("| mkfile     | Create a new file in the current dir |");
            Console.WriteLine("| mkdir      | Create a new dir in the current dir  |");
            Console.WriteLine("| run        | Run a ThreeScript File               |");
            Console.WriteLine("| echo       | Print text to the Console            |");
            Console.WriteLine("| rm [-r]    | Remove a file or Directory [rm -r]   |");
            Console.WriteLine("-----------------------------------------------------");

        }

        public static void SysinfoCMD() {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("| User      | Admin            |");
            Console.WriteLine("| OS        | ThreeOS Beta     |");
            Console.WriteLine($"| Version   | Build {VersionInfo.BuildVersion}   |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Hardware:");
            Console.WriteLine($"Total RAM: {Cosmos.Core.CPU.GetAmountOfRAM()} MB ");
            Console.WriteLine($"CPU: {Cosmos.Core.CPU.GetCPUVendorName()}");

        }

        public static void ClearCMD() {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static void ShutdownCMD() {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Shutdowning PC...");
            System.Threading.Thread.Sleep(3000);
            Sys.Power.Shutdown();

        }

        public static void RestartCMD() {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Restarting PC...");
            System.Threading.Thread.Sleep(3000);
            Sys.Power.Reboot();

        }

        public static void CdCMD(string pathname) {

            if (!Directory.Exists(pathname))
            {
                ConsoleInfo.Error("This Directory doesnt exist!");
            }
            else
            {
                Kernel.CurrentDirectory = pathname;
            }

        }

        public static void LsCMD() {

            string[] directory_list = Directory.GetFiles(Kernel.CurrentDirectory);
            foreach (var file in directory_list)
            {
                Console.WriteLine(file);
            }

        }

        public static void MkfileCMD(string filename) {

            if (filename == "")
            {
                ConsoleInfo.Error("Please enter a File name");
            }
            else
            {
                try
                {
                    var file_stream = File.Create(Kernel.CurrentDirectory + filename);
                }
                catch (Exception e)
                {
                    ConsoleInfo.Error(e.ToString());
                }
                ConsoleInfo.OK("File successfully created.");
            }

        }

        public static void MkdirCMD(string dirname) {

            if (dirname == "")
            {
                Console.WriteLine("Please enter an dir name!");
            }
            else
            {
                if (!Directory.Exists(dirname))
                {
                    try
                    {
                        var directory_stream = Directory.CreateDirectory(Kernel.CurrentDirectory + dirname);
                    }
                    catch (Exception e)
                    {
                        ConsoleInfo.Error(e.ToString());
                    }
                    ConsoleInfo.OK("Directory successfully created.");
                }
                else
                {
                    ConsoleInfo.Error("This Directory already exists!");
                }
            }

        }

        public static void RunCMD(string tscriptpath) {

            if (tscriptpath == "")
            {
                ConsoleInfo.Error("Not a valid ThreeScript File!");
            }
            else
            {
                TScriptEngine.Execute(tscriptpath);
            }

        }

        public static void EchoCMD(string message) {

            Console.WriteLine(message);

        }

    }

}
