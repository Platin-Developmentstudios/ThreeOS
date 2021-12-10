using System;
using System.IO;
using System.Text;
using ThreeOS.System.ConsoleTools;

namespace ThreeOS.System.ThreeScript
{
   internal class ThreeScript
   {
      public static void Execute(string filename)
      {
          
 ​            ​try 
 ​            { 
 ​                ​if​ ((​filename​.​EndsWith​(​"​.ths"​)) ​||​ (​filename​.​EndsWith​(​"​.threescript"​))) 
 ​                { 
 ​                    ​string​[] ​lines​ ​=​ ​File​.​ReadAllLines​(​filename​); 
 ​                    ​foreach​ (​string​ ​line​ ​in​ ​lines​) 
 ​                    { 
 ​                        ​if​(​!​(​line​.​StartsWith​(​"​|"​)))
 ​                        { 
                             // Work in Progress
 ​                        } 
 ​                    } 
 ​                } 
 ​                ​else 
 ​                { 
 ​                    ​ConsoleInfo.Error(​"Not a valid script​"​); 
 ​                } 
 ​            } 
 ​            ​catch​ (​Exception​ ​e) 
 ​            { 
 ​                ​Console​.​WriteLine​(​e.ToString()); 
 ​            }
      }
   }
}
