using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using ThreeOS.System.ConsoleTools;
using ThreeOS.System.ThreeScript;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace ThreeOS
{
    public class Kernel: Sys.Kernel
    {

        public static string CurrentDirectory = @"0:\system\mnt\";
        public static string ComputerName = "ThreeOS";
        public static string CurrentUser = "Admin";
        public static string BuildVer = "04012022";

        protected override void BeforeRun() {

            ConsoleInfo.Wait("Initialize FileSystem...");
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            ConsoleInfo.OK("FileSystem Initialized");

            ConsoleInfo.Wait("Checking System...");
            if (!Directory.Exists(@"0:\system")) {
                ConsoleInfo.Wait("Creating Directorys...");
                try
                {

                    Directory.CreateDirectory(@"0:\system");
                    Directory.CreateDirectory(@"0:\system\dev");
                    Directory.CreateDirectory(@"0:\system\mnt");
                    Directory.CreateDirectory(@"0:\system\cfg");
                    Directory.CreateDirectory(@"0:\system\var");

                }
                catch (Exception e) {

                    ConsoleInfo.Error(e.ToString());

                }
                ConsoleInfo.Info("Directorys Created.");
            }
            ConsoleInfo.OK("System Check");
            Console.Clear();
            ConsoleUtils.WriteLogo();
        }
        
        protected override void Run() {
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(CurrentUser);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(ComputerName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(CurrentDirectory);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" > ");

            var input = Console.ReadLine();
            
            if(input.StartsWith("help")) {
                
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
                Console.WriteLine("-----------------------------------------------------");
                    
            } else if(input.StartsWith("sysinfo")) {
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------------");
                Console.WriteLine("| User      | Admin            |");
                Console.WriteLine("| OS        | ThreeOS Beta     |");
                Console.WriteLine("| Version   | Build 04012022   |");
                Console.WriteLine("--------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Hardware:");
                Console.WriteLine($"Total RAM: {Cosmos.Core.CPU.GetAmountOfRAM()} MB ");
                Console.WriteLine($"CPU: {Cosmos.Core.CPU.GetCPUVendorName()}");
                 
            } else if(input.StartsWith("clear")) {
            
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
            
            } else if(input.StartsWith("shutdown")) {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shutdowning PC...");
                System.Threading.Thread.Sleep(3000);
                Sys.Power.Shutdown();
                    
            } else if(input.StartsWith("restart")) {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Restarting PC...");
                System.Threading.Thread.Sleep(3000);
                Sys.Power.Reboot();
            
            } else if(input.StartsWith("cd")) {
                
                string dirPath = input.Remove(0, 3);
                if (!Directory.Exists(dirPath)) {
                    ConsoleInfo.Error("This Directory doesnt exist!");
                } else {
                    CurrentDirectory = dirPath;
                }
                    
            } else if(input.StartsWith("ls")) {
                
                string directory_list = Directory.GetFiles(CurrentDirectory);
                foreach(var file in directory_list) {
                    Console.WriteLine(file);
                }
                
            } else if(input.StartsWith("mkfile")) {
                
                string filename = input.Remove(0, 7);
                if(filename == "") {
                    ConsoleInfo.Error("Please enter a File name");
                } else {
                    try {
                        var file_stream = File.Create(CurrentDirectory + filename);
                    } catch(Exception e) {
                        ConsoleInfo.Error(e.ToString());
                    }
                    ConsoleInfo.OK("File successfully created.");
                }
                    
            } else if(input.StartsWith("mkdir")) {
                
                if (input == "") {
                    Console.WriteLine("Please enter an dir name!");
                } else {
                    if(!Directory.Exists(dirname)) {
                        try {
                            var directory_stream = Directory.Create(CurrentDirectory + dirname);
                        }
                        catch(Exception e) {
                            ConsoleInfo.Error(e.ToString());
                        }
                        ConsoleInfo.OK("Directory successfully created.");
                    } else {
                        ConsoleInfo.Error("This Directory already exists!");
                    }
                }
                    
            } else if(input.StartsWith("run")) {
                
                string TScriptPath = input.Remove(0, 4);
                if(TScriptPath == "") {
                    ConsoleInfo.Error("Not a valid ThreeScript File!");
                } else {
                    TScriptEngine.Execute(TScriptPath);
                }
                    
            } else if(input.StartsWith("echo")) {
                
                string echoString = input.Remove(0, 5);
                Console.WriteLine(echoString);
                    
            } else {
            
                ConsoleInfo.Error("Command not Found");
                
            }
        }
    }
}

