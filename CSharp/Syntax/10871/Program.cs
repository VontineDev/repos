using System;

namespace _10871
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int x = int.Parse(arr[0]);
            int n = int.Parse(arr[1]);

            string sequence = Console.ReadLine();
            string[] arr2 = sequence.Split(' ');

            for(int i =0; i<arr2.Length; i++)
            {
                if(n>int.Parse(arr2[i]))
                {
                    Console.Write($"{int.Parse(arr2[i])} ");
                }
            }

        }
    }
}
