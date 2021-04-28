using System;

namespace _1330
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);

            if (a>b)
            {
                Console.WriteLine(">");
            }
            else if (a<b)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
