using System;
namespace _11920
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initCondition = Console.ReadLine().Split(' ');
            int N = int.Parse(initCondition[0]);
            int K = int.Parse(initCondition[1]);
            int cnt = 0;
            string[] str = Console.ReadLine().Split(' ');
            int[] arr = new int[N];
            
            for(int i=0; i< N; i++)
            {
                arr[i] = int.Parse(str[i]);
            }

            for(int i=0; i< N; i++)
            {
                for(int j=i; j<N-(i+1); j++)
                {
                    int temp;
                    if(arr[j]>arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }                    
                }
                cnt++;
                if (cnt != K)
                {

                }
                else
                { break; }
            }
            
            for(int i =0; i<arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
