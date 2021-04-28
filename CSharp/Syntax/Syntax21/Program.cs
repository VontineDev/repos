using System;

namespace Syntax21
{
    class Program
    {
        static void Main(string[] args)
        {
            //0~10출력
            int i = 0;
            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine();

            //1<= i <=20 짝수를 출력
            int j = 1;
            while (j < 21)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
            Console.WriteLine();


            //1<= i <=20 홀수를 출력
            int k = 1;
            while (k < 21)
            {
                if (k % 2 != 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }
            Console.WriteLine();


            //1 <= i <= 20 3의 배수를 출력
            int l = 1;
            while (l < 21)
            {
                if (l % 3 == 0)
                {
                    Console.WriteLine(l);
                }
                l++;
            }
        }
    }
}
