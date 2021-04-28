using System;

namespace _1436
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            int num = 0;
            while (cnt != n)
            {
                string tmp = num.ToString();
                if (tmp.Contains("666"))
                {
                    cnt++;
                }
                if (cnt == n)
                {
                    break;
                }
                num++;
            }
            Console.WriteLine(num);

        }
    }
}
