using System;
using System.Text;
namespace _2750
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int num = int.Parse(Console.ReadLine());           
            int[] arr = new int[num];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < arr.Length-1; j++)
            {
                for (int i = arr.Length - 1; i > j; i--)
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
                sb.AppendLine(arr[i].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
