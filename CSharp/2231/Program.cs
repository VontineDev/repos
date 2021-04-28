using System;

namespace _2231
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum;
            int part;

            for (int i = 1; i < num; i++)
            {
                sum = i;
                part = i;
                while (part != 0)
                {
                    sum += part % 10;
                    part /= 10;
                }
                if (num == sum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(0);
            return;
        }
    }
}
