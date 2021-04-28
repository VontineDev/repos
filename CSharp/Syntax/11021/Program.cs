using System;

namespace _11021
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());

            for(int i = 0; i<testcase; i++)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split(' ');
                int a = int.Parse(arr[0]);
                int b = int.Parse(arr[1]);

                Console.WriteLine($"Case #{i+1}: {a + b}");
            }
        }
    }
}
