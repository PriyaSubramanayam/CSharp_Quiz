namespace Quiz_Beginners
{
    class CSharpBasics
    {

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
       
        // initialize the DEVMODE structure
DEVMODE dm = new DEVMODE();
dm.dmDeviceName = new string(new char[32]);
dm.dmFormName = new string(new char[32]);
dm.dmSize = Marshal.SizeOf(dm);

if (0 != NativeMethods.EnumDisplaySettings(
null,
NativeMethods.ENUM_CURRENT_SETTINGS,
ref dm))
{
   // swap width and height
   int temp = dm.dmPelsHeight;
   dm.dmPelsHeight = dm.dmPelsWidth;
   dm.dmPelsWidth = temp;

   // determine new orientation
   switch(dm.dmDisplayOrientation)
   {
      case NativeMethods.DMDO_DEFAULT:
         dm.dmDisplayOrientation = NativeMethods.DMDO_270;
         break;
      case NativeMethods.DMDO_270:
         dm.dmDisplayOrientation = NativeMethods.DMDO_180;
         break;
      case NativeMethods.DMDO_180:
         dm.dmDisplayOrientation = NativeMethods.DMDO_90;
         break;
      case NativeMethods.DMDO_90:
         dm.dmDisplayOrientation = NativeMethods.DMDO_DEFAULT;
         break;
      default:
         // unknown orientation value
         // add exception handling here
         break;
   }

   int iRet = NativeMethods.ChangeDisplaySettings(ref dm, 0);
   if (NativeMethods.DISP_CHANGE_SUCCESSFUL != iRet)
   {
      // add exception handling here
   }
}

/// </summary>
/// 

        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /*
 * C# Program to Generate the Factorial of  Given Number 
 */
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace factorial
    {
        class Program
        {
            static void Main(string[] args)
            {
                int i, number=5, fact;
                Console.WriteLine("Enter the Number");
                number = int.Parse(Console.ReadLine());
                fact = number;
                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine("\nFactorial of Given Number is: " + fact);
                Console.ReadLine();
            }
        }
    }
        
   /// </summary>
   /// 


        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reverse_string
{
    static class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

       class Program1
        {
            public static object StringHelper { get; private set; }

            static void Main()
            {
                string name;
                Console.WriteLine("Test User");
                Console.WriteLine(ReverseString("Allen"));
                Console.WriteLine(ReverseString("Sammy"));
                Console.WriteLine(ReverseString("example string"));
            }
        }
    }
}
        /// </summary>
        /// 


        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        /// 



    }
}
