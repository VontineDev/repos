using System;
namespace _10952
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;           
            while ((str = Console.ReadLine()) != null)
            {
                string[] arr = str.Split(' ');
                int a = int.Parse(arr[0]);
                int b = int.Parse(arr[1]);
                Console.WriteLine($"{a}, {b}");
            }
        }
    }
}