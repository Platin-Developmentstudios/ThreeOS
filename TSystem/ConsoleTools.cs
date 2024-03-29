﻿using System;
using System.Text;
using ThreeOS.TSystem.VersionUtils;

namespace ThreeOS.TSystem.ConsoleTools
{
  internal class ConsoleUtils
  {
    public static void WriteLogo()
    {
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine(" ********** **                                     *******    ********", ConsoleColor.Magenta);
         Console.WriteLine("/////**/// /**                                    **/////**  **////// ", ConsoleColor.Magenta);
         Console.WriteLine("    /**    /**      ******  *****   *****        **     //**/**       ", ConsoleColor.Magenta);
         Console.WriteLine("    /**    /****** //**//* **///** **///**      /**      /**/*********", ConsoleColor.Magenta);
         Console.WriteLine("    /**    /**///** /** / /*******/*******      /**      /**////////**", ConsoleColor.Magenta);
         Console.WriteLine("    /**    /**  /** /**   /**//// /**////       //**     **        /**", ConsoleColor.Magenta);
         Console.WriteLine("    /**    /**  /**/***   //******//******       //*******   ******** ", ConsoleColor.Magenta);
         Console.WriteLine("    //     //   // ///     //////  //////         ///////   ////////  ", ConsoleColor.Magenta);
         Console.WriteLine("");
         Console.ForegroundColor = ConsoleColor.DarkCyan;
         Console.WriteLine("  ------------------------------------------------------------------  ", ConsoleColor.Magenta);
         Console.WriteLine($"  |  Beta Build {VersionInfo.BuildVersion}  |  Created By Platin Developmentstudios  |  ", ConsoleColor.Magenta);
         Console.WriteLine("  ------------------------------------------------------------------  ", ConsoleColor.Magenta);
         Console.WriteLine("", ConsoleColor.Green);
         Console.ForegroundColor = ConsoleColor.White;
    }

    public static void PrintCmdLine()
    {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Kernel.CurrentUser);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(Kernel.ComputerName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(Kernel.CurrentDirectory);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" > ");
        }
  }
  internal class ConsoleInfo
  {
    


    public static void OK(string text)
    {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n[ OK ] ", ConsoleColor.Green);
            Console.WriteLine(text, ConsoleColor.White);
            Console.ForegroundColor = ConsoleColor.White;
    }
    
    public static void Wait(string text)
    {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[ ... ] ", ConsoleColor.Cyan);
            Console.WriteLine(text, ConsoleColor.White);
            Console.ForegroundColor = ConsoleColor.White;
    }
    
    public static void Error(string text)
    {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n[ Error ] ");
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
    }
    
    public static void Warning(string text)
    {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n[ Warning ] ");
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
    }
    
    public static void Info(string text)
    {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n[ Info ] ");
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
  }
}
