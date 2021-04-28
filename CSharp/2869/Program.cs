using System;

namespace _2869
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            int v = int.Parse(str[2]);
            int day = (v - b - 1) / (a - b) + 1;

            Console.WriteLine(day);
        }
    }
}
