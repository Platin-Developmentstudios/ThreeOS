﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;

namespace ThreeOS
{
    public class Kernel : Sys.Kernel
    {

        //Canvas canvas;

        protected override void BeforeRun()
        {

            //canvas = FullScreenCanvas.GetFullScreenCanvas();
            //canvas.Clear(Color.Wheat);

            Console.WriteLine("------------------------------------------------------------------", ConsoleColor.Cyan);
            Console.WriteLine("| ThreeOS Beta Build 3010 | Created By Platin Developmentstudios |", ConsoleColor.Cyan);
            Console.WriteLine("------------------------------------------------------------------", ConsoleColor.Cyan);
            Console.WriteLine("| To see all commands, type in help                              |", ConsoleColor.Cyan);
            Console.WriteLine("------------------------------------------------------------------", ConsoleColor.Cyan);
        }

        protected override void Run()
        {
            Console.WriteLine("root@ThreeOS > ");
            var input = Console.ReadLine();

            if (input == "help")
            {

                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("| sysinfo    | Show infos about the ThreeOS build |");
                Console.WriteLine("| clear      | Clear the Console                  |");
                Console.WriteLine("| shutdown   | Shut down the PC                   |");
                Console.WriteLine("| restart    | Restart the PC                     |");
                Console.WriteLine("---------------------------------------------------");

            } else if (input == "sysinfo")
            {

                Console.WriteLine("----------------------------");
                Console.WriteLine("| User      | root@ThreeOS |");
                Console.WriteLine("| OS        | ThreeOS Beta |");
                Console.WriteLine("| Version   | Build 3010   |");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Hardware:");
                Console.WriteLine($"Total RAM: {Cosmos.Core.CPU.GetAmountOfRAM()} MB ");
                Console.WriteLine($"CPU: {Cosmos.Core.CPU.GetCPUVendorName()}");

            } else if (input == "clear")
            {

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
