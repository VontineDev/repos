using System;

namespace _2438
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());

            for(int i =0; i<testcase; i++)
            {
                for(int j =0; j<i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
