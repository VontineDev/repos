using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2750_using_insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] str2 = str.Split(' ');
            int[] arr = new int[str2.Length];

            for (int i = 0; i < str2.Length; i++)
            {
                arr[i] = int.Parse(str2[i]);
            }


            for (int j = 1; j < arr.Length; j++)
            {
                for (int i = j; i > 0; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        int temp;
                        temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
