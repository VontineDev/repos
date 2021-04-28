using System;

namespace _2739
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for(int i = 1; i<10; i++)
            {
                Console.WriteLine($"{input} * {i} = {input * i}");
            }
        }
    }
}
