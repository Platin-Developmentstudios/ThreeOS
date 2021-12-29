using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using ThreeOS.System.ConsoleTools;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace ThreeOS
{
    public class Kernel : Sys.Kernel
    {
      
        public static string CurrentDirectory = @"0:\system\mnt\";
        public static string ComputerName = "ThreeOS";
        public static string CurrentUser = "Admin";
        public static string BuildVer = "2912";
        
        protected override void BeforeRun()
        {

            ConsoleInfo.Wait("Initialize FileSystem...");
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            ConsoleInfo.OK("FileSystem Initialized");
            
            ConsoleInfo.Wait("Checking System..."); 
            if (!Directory.Exists(@"0:\system"))
            {
                ConsoleInfo.Wait("Creating Directorys...");
                try
                {
              
                  Directory.CreateDirectory(@"0:\system");
                  Directory.CreateDirectory(@"0:\system\dev");
                  Directory.CreateDirectory(@"0:\system\mnt");
                  Directory.CreateDirectory(@"0:\system\cfg");
                  Directory.CreateDirectory(@"0:\system\var");
                
                }
                catch (Exception e)
                {

                  Console.WriteLine(e.ToString());

                }
                ConsoleInfo.Info("Directorys Created.");
            }
            ConsoleInfo.OK("System Check");
            Console.Clear();
            ConsoleUtils.WriteLogo();
        }

        protected override void Run()
        {
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

            if (input == "help")
            {
            
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
                Console.WriteLine("-----------------------------------------------------");

            } else if (input == "sysinfo")
            {
            
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------------------------");
                Console.WriteLine("| User      | Admin        |");
                Console.WriteLine("| OS        | ThreeOS Beta |");
                Console.WriteLine("| Version   | Build 2912   |");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Hardware:");
                Console.WriteLine($"Total RAM: {Cosmos.Core.CPU.GetAmountOfRAM()} MB ");
                Console.WriteLine($"CPU: {Cosmos.Core.CPU.GetCPUVendorName()}");

            } else if (input == "clear")
            {
            
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;


            } else if (input == "shutdown")
            {
            
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Shutdowning PC...");
                System.Threading.Thread.Sleep(3000);
                Sys.Power.Shutdown();

            } else if (input == "restart")
            {
            
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Restarting PC...");
                System.Threading.Thread.Sleep(3000);
                Sys.Power.Reboot();

            } else if (input == "cd")
            {

                Console.WriteLine("Enter the Path to the Directory");
                string dirPath = Console.ReadLine();
                if (!Directory.Exists(dirPath))
                {
                    Console.WriteLine("This Directory doesnt exist!");
                } else {
                    CurrentDirectory = dirPath;
                }

            } else if​ (​input​ ​==​ ​"​ls​"​) 
 ​           { 
 ​                ​var​ ​directory_list​ ​=​ ​Directory​.​GetFiles​(​CurrentDirectory); 
 ​                ​foreach​ (​var​ ​file​ ​in​ ​directory_list​) 
 ​                { 
 ​                    ​Console​.​WriteLine​(​file​); 
 ​                } 

 ​            } else if​ (​input​ ​==​ ​"​mk​file"​) 
 ​            { 
 ​                ​Console​.​Write​(​"​File name with extension: ​"​); 
 ​                ​string​ ​filename​ ​=​ ​Console​.​ReadLine​(); 
  
 ​                ​try 
 ​                { 
 ​                    ​var​ ​file_stream​ ​=​ ​File​.​Create(CurrentDirectory ​+​ ​filename​); 
 ​                } 
 ​                ​catch​ (​Exception​ ​e​) 
 ​                { 
 ​                    ​Console​.​WriteLine​(​e​.​ToString​()); 
 ​                } 
 ​                ​Console​.​WriteLine​(​"​File successfully created​"​); 

 ​            } else if (input == "mkdir")
             {
                 Console.WriteLine("Directory Name:");
                 string dirname = Console.ReadLine();
                 if (!Directory.Exists(dirname))
                 {
                     try
                     {
                         var directory_stream = Directory.Create(CurrentDirectory + dirname);
                     }
                     catch(Exception e)
                     {
                          Console.WriteLine(e.ToString());
                     }
                     Console​.​WriteLine​(​"​Directory successfully created​"​); 
                 } else {
                     Console.WriteLine("This Directory does already exists!");
                 }
             } else {
                ConsoleInfo.Error("Command not Found");
            }
        }
    }
}
