using System;

namespace _2798
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tmp1 = Console.ReadLine().Split(' ');
            int n = int.Parse(tmp1[0]);
            int m = int.Parse(tmp1[1]);

            string[] tmp2 = Console.ReadLine().Split(' ');
            int[] arr = new int[n];

            if (tmp2.Length != n)
            {
                return;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(tmp2[i]);
            }

            int sum = m;
            int diff = m;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        int tmpSum = arr[i] + arr[j] + arr[k];
                        if ( (m-tmpSum)>=0 && (m-tmpSum)<diff)
                        {
                            diff = m - tmpSum;
                            sum = tmpSum;
                        }
                    }
                }
            }

            Console.WriteLine(sum);

        }
    }
}
