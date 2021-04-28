using System;

namespace _10952
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split(' ');
                int a = int.Parse(arr[0]);
                int b = int.Parse(arr[1]);
                if (a == 0 && b == 0)
                {
                    break;
                }
                Console.WriteLine(a + b);
            }
        }
    }
}
