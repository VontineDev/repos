using System;

namespace _7568
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, 2];
            int[] rank = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] tmp = Console.ReadLine().Split();
                arr[i, 0] = int.Parse(tmp[0]);
                arr[i, 1] = int.Parse(tmp[1]);
                rank[i] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && arr[i, 0] < arr[j, 0] && arr[i, 1] < arr[j, 1])
                    {
                        rank[i]++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(rank[i]);
                Console.Write(" ");
            }
        }
    }
}
