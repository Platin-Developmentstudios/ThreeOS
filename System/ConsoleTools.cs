using System;
using System.Text;

namespace ThreeOS.System.ConsoleTools
{
  internal class ConsoleUtils
  {
    public static void logo()
    {
         Console.ForegroundColor = ConsoleColor.Magenta;
         Console.WriteLine(" ********** **                                     *******    ********", ConsoleColor.Magenta);
         Console.WriteLine("/////**/// /**                                    **/////**  **////// ", ConsoleColor.Magenta);
         Console.WriteLine("    /**    /**      ******  *****   *****        **     //**/**       ", ConsoleColor.Magenta);
         Console.WriteLine("    /**    /****** //**//* **///** **///**      /**      /**/*********", ConsoleColor.Magenta);
         Console.WriteLine("    /**    /**///** /** / /*******/*******      /**      /**////////**", ConsoleColor.Magenta);
         Console.WriteLine("    /**    /**  /** /**   /**//// /**////       //**     **        /**", ConsoleColor.Magenta);
         Console.WriteLine("    /**    /**  /**/***   //******//******       //*******   ******** ", ConsoleColor.Magenta);
         Console.WriteLine("    //     //   // ///     //////  //////         ///////   ////////  ", ConsoleColor.Magenta);
         Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
         Console.WriteLine("  ------------------------------------------------------------------  ", ConsoleColor.Magenta);
         Console.WriteLine("  |    Beta Version 0412  |   Created By Platin Developmentstudios |  ", ConsoleColor.Magenta);
         Console.WriteLine("  ------------------------------------------------------------------  ", ConsoleColor.Magenta);
         Console.WriteLine("", ConsoleColor.Green);
         Console.ForegroundColor = ConsoleColor.White;
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
