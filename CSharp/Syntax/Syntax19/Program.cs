using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax19
{
    class Program
    {
        static void Main(string[] args)
        {
            //#FFFF00       YELLO
            //#000000       BLACK
            //#FF0000       RED
            //#0000FF       BLUE
            //#00FF00       GREEN
            //#AC0000       NONE

            //string input1 = Console.ReadLine();
            //switch (input1)
            //{
            //    case "#FFFF00":
            //        Console.WriteLine("YELLO");
            //        break;
            //    case "#000000":
            //        Console.WriteLine("BLACK");
            //        break;
            //    case "#FF0000":
            //        Console.WriteLine("RED");
            //        break;
            //    case "#0000FF":
            //        Console.WriteLine("BLUE");
            //        break;
            //    case "#00FF00":
            //        Console.WriteLine("GREEN");
            //        break;
            //    default:
            //        Console.WriteLine("NONE");
            //        break;
            //}


            //1     Monday
            //2     Tuesday
            //3     Wednesday
            //4     Thursday
            //5     Friday
            //6     Saturday
            //7     Sunday

            //int input2 = int.Parse(Console.ReadLine());
            //switch (input2)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Tursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        break;
            //}


            //Edge Not available
            //Chrome  Available
            //Firefox  Available
            //Safari  Available
            //Opera  Not available

            //string input3 = Console.ReadLine();
            //switch (input3)
            //{
            //    case "Edge":
            //        Console.WriteLine("Not available");
            //        break;
            //    case "Chrome":
            //        Console.WriteLine("Available");
            //        break;
            //    case "Firefox":
            //        Console.WriteLine("Available");
            //        break;
            //    case "Safari":
            //        Console.WriteLine("Available");
            //        break;
            //    case "Opera":
            //        Console.WriteLine("Not available");
            //        break;
            //}


            ////두 수 3, 2가 있습니다. 
            ////연산자를 입력하여 연산될 결과를 출력하세요.

            //float a = 3;
            //float b = 2;
            //string input4 = Console.ReadLine();
            //switch (input4)
            //{
            //    case "+":
            //        Console.WriteLine(a + b);
            //        break;
            //    case "-":
            //        Console.WriteLine(a - b);
            //        break;
            //    case "*":
            //        Console.WriteLine(a * b);
            //        break;
            //    case "/":
            //        Console.WriteLine(a / b);
            //        break;
            //    case "%":
            //        Console.WriteLine(a % b);
            //        break;
            //    default:
            //        break;
            //}


            //범위: 1 ≤ num ≤ 5

            //1 
            //One

            //2 
            //Two
            //Two

            //3 
            //Three
            //Three
            //Three

            int input5 = int.Parse(Console.ReadLine());
            switch (input5)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    Console.WriteLine("Three");
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    Console.WriteLine("Four");
                    Console.WriteLine("Four");
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    Console.WriteLine("Five");
                    Console.WriteLine("Five");
                    Console.WriteLine("Five");
                    Console.WriteLine("Five");
                    break;

                default:
                    break;
            }
        }
    }
}
