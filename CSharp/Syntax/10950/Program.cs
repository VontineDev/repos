using System;

namespace _10950
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            int[] a = new int[inputNum];
            int[] b = new int[inputNum];
            for (int i = 0; i < inputNum; i++)
            {
                string input = Console.ReadLine();
                string[] arr = input.Split(' ');
                a[i] = int.Parse(arr[0]);
                b[i] = int.Parse(arr[1]);
            }

            for (int i = 0; i < inputNum; i++)
            {
                Console.WriteLine(a[i] + b[i]);
            }
        }
    }
}
