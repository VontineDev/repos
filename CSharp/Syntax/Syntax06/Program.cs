using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax06
{
    class Program
    {
        static void Main(string[] args)
        {
            Restart:
            Console.WriteLine("줄넘기를 하려면 D 키를 입력 해주세요.");
            ConsoleKeyInfo info = Console.ReadKey();
            bool condition = info.KeyChar == 'd';
            
            if (condition)
            {
                Console.Write("몇회 줄넘기를 할건가요? ");
                int count = Int32.Parse(Console.ReadLine());

                Console.Clear();

                for (int i = 1; i < count+1; i++)
                {
                    Console.Write("줄넘기를 ");
                    if (i % 2 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(i);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(i);
                    }

                    Console.Write("회 했습니다.");
                    if (i%3 == 0)
                    {
                        Console.WriteLine(" (\"야호!\")" );
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                
            }
            else
            {
                Console.Clear();
                goto Restart;

             }
        }
    }
}
