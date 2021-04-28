using System;

namespace _1978
{
    class Program
    {
        static void Main(string[] args)
        {
            int testInput = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] numbers = new int[testInput];

            int cnt = 0;
            for(int i =0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(str[i]);
                
                if(numbers[i]%2!=0)
                {
                    for (int j = 2; j < numbers[i]+1; j++)
                    {
                        if (numbers[i] % j != 0)
                        {
                            cnt++;
                            break;
                        }
                    }
                }
                if (numbers[i] == 2)
                {
                    cnt++;
                    continue;
                }
            }
            Console.WriteLine(cnt);

        }
    }
}
