using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stntax03
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("줄넘기를 하려면 D 키를 입력 해주세요.");
                ConsoleKeyInfo keyinfo2 = Console.ReadKey();
                bool input = keyinfo2.KeyChar == 'd';
                //string a = keyinfo2.KeyChar.ToString(); //ConsoleKeyInfo 형태를 string 형태로 바꾸기
                Console.Clear();
                if (input)
                {
                    Console.Write("몇회 줄넘기를 할건가요?");
                    string strcount = Console.ReadLine();
                    int count = Convert.ToInt32(strcount);
                    for (int i = 1; i <= count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write($"줄넘기를 {i}회 했습니다.");
                        }
                        else
                        {
                            Console.Write("줄넘기를 ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(i);
                            Console.ResetColor();
                            Console.Write("회 했습니다.");
                        }
                        if (i % 3 == 0)
                        {
                            Console.Write("(\"야호!\")");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("줄넘기를 하지 못했습니다");
                }
            }
        }
    }
}