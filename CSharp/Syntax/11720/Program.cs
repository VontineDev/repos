using System;

namespace _11720
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int[] num = new int[input];
            int sum = 0;
            
            for (int j = 0; j < input; j++)
            {
                num[j] = Convert.ToInt32(str[j])-48;
            }
            
            for (int i = 0; i < input; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine(sum);
        }
    }
}
