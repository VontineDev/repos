using System;

namespace _2439
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());

            for (int i = 0; i < testcase; i++)
            {
                for (int j = testcase-1; j > i; j--)
                {
                    Console.Write(" ");               
                }
                for (int k = 0; k<i+1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
