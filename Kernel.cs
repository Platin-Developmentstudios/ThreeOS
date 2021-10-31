using System;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace ThreeOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("------------------------------------------------------------------", ConsoleColor.Magenta);
            Console.WriteLine("| ThreeOS Beta Build 3110 | Created By Platin Developmentstudios |", ConsoleColor.Magenta);
            Console.WriteLine("------------------------------------------------------------------", ConsoleColor.Magenta);
            Console.WriteLine("| To see all commands, type in help                              |", ConsoleColor.Magenta);
            Console.WriteLine("------------------------------------------------------------------", ConsoleColor.Magenta);
        }

        protected override void Run()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("root@ThreeOS > ", ConsoleColor.White);
            var input = Console.ReadLine();

            if (input == "help")
            {

                Console.WriteLine("---------------------------------------------------", ConsoleColor.White);
                Console.WriteLine("| sysinfo    | Show infos about the ThreeOS build |", ConsoleColor.White);
                Console.WriteLine("| clear      | Clear the Console                  |", ConsoleColor.White);
                Console.WriteLine("| shutdown   | Shut down the PC                   |", ConsoleColor.White);
                Console.WriteLine("| restart    | Restart the PC                     |", ConsoleColor.White);
                Console.WriteLine("---------------------------------------------------", ConsoleColor.White);

            } else if (input == "sysinfo")
            {

                Console.WriteLine("----------------------------", ConsoleColor.White);
                Console.WriteLine("| User      | root@ThreeOS |", ConsoleColor.White);
                Console.WriteLine("| OS        | ThreeOS Beta |", ConsoleColor.White);
                Console.WriteLine("| Version   | Build 3110   |", ConsoleColor.White);
                Console.WriteLine("----------------------------", ConsoleColor.White);
                Console.WriteLine(" ");
                Console.WriteLine("Hardware:", ConsoleColor.White);
                Console.WriteLine($"Total RAM: {Cosmos.Core.CPU.GetAmountOfRAM()} MB ", ConsoleColor.White);
                Console.WriteLine($"CPU: {Cosmos.Core.CPU.GetCPUVendorName()}", ConsoleColor.White);

            } else if (input == "clear")
            {

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();

            } else if (input == "shutdown")
            {

                Console.WriteLine("Shutdowning PC...", ConsoleColor.Red);
                System.Threading.Thread.Sleep(3000);
                Sys.Power.Shutdown();

            } else if (input == "restart")
            {

                Console.WriteLine("Restarting PC...", ConsoleColor.Red);
                System.Threading.Thread.Sleep(3000);
                Sys.Power.Reboot();

            }
        }
    }
}
