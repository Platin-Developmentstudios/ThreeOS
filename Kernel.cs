using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace ThreeOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("------------------------------------------------------------------", ConsoleColor.Cyan);
            Console.WriteLine("| ThreeOS Beta Build 2810 | Created By Platin Developmentstudios |", ConsoleColor.Cyan);
            Console.WriteLine("------------------------------------------------------------------", ConsoleColor.Cyan);
            Console.WriteLine("| To see all commands, type in help                              |", ConsoleColor.Cyan);
            Console.WriteLine("------------------------------------------------------------------", ConsoleColor.Cyan);
        }

        protected override void Run()
        {
            Console.Write("root@ThreeOS > ");
            var input = Console.ReadLine();

            if(input == "help")
            {
                Console.WriteLine("- sysinfo | Show infos about the ThreeOS build");
            } else if(input == "sysinfo")
            {
                Console.WriteLine("User    | root@ThreeOS");
                Console.WriteLine("OS      | ThreeOS Beta");
                Console.WriteLine("Version | Build 2810");
            }
        }
    }
}
