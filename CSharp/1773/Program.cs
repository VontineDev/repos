using System;
using System.Collections.Generic;
namespace _1773
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] str2 = str.Split(' ');              
            int numberOfStudent = int.Parse(str2[0]+"");
            int timeWhenShowIsOver = int.Parse(str2[1]+"");
            Dictionary<int,int> observatedTime = new Dictionary<int,int>();
            int[] period = new int[numberOfStudent];
            int minPeriod = timeWhenShowIsOver;
            for(int i=0; i < numberOfStudent; i++)
            {
                period[i] = int.Parse(Console.ReadLine());
                minPeriod = Math.Min(minPeriod, period[i]);

            }

            for(int j=0; j<numberOfStudent; j++)
            {
                for (int i = 1; i < (timeWhenShowIsOver / minPeriod) + 1; i++)
                {
                    if (period[j]*i<=timeWhenShowIsOver && observatedTime.ContainsKey(period[j] * i) == false)
                    {
                        observatedTime.Add(period[j] * i, 1);
                    }
                }
            } 
            Console.WriteLine(observatedTime.Count);


        }
    }
}
