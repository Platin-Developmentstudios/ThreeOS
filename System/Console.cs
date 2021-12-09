using System;
using System.Text;

namespace ThreeOS.System.Console
{
  internal class ConsoleInfo
  {
    public static void OK(string text)
    {
      Console.Write("\n[ OK ] ", ConsoleColor.Green);
      Console.Write(text, ConsoleColor.White);
    }
    
    public static void Wait(string text)
    {
      Console.Write("\n[ ... ] ", ConsoleColor.Cyan);
      Console.Write(text, ConsoleColor.White);
    }
    
    public static void Error(string text)
    {
      Console.Write("\n[ ERROR ] ", ConsoleColor.Red);
      Console.Write(text, ConsoleColor.White);
    }
    
    public static void Warning(string text)
    {
      Console.Write("\n[ WARNING ] ", ConsoleColor.Yellow);
      Console.Write(text, ConsoleColor.White);
    }
    
    public static void Info(string text)
    {
      Console Write("\n[ INFO ] ", ConsoleColor.Cyan);
      Console.Wrtite(text, ConsoleColor.White);
    }
  }
}
