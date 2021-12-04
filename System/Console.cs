using System;

namespace ThreeOS.System.Console
{
  internal class ConsoleInfo
  {
    public static void OK(string text)
    {
      Write("\n[ OK ] ", ConsoleColor.Green);
      Write(text, ConsoleColor.White);
    }
    
    public static void Wait(string text)
    {
      Write("\n[ ... ] ", ConsoleColor.Cyan);
      Write(text, ConsoleColor.White);
    }
    
    public static void Error(string text)
    {
      Write("\n[ ERROR ] ", ConsoleColor.Red);
      Write(text, ConsoleColor.White);
    }
    
    public static void Warning(string text)
    {
      Write("\n[ WARNING ] ", ConsoleColor.Yellow);
      Write(text, ConsoleColor.White);
    }
    
    public static void Info(string text)
    {
      Write("\n[ INFO ] ", ConsoleColor.Cyan);
      Wrtite(text, ConsoleColor.White);
    }
  }
}
