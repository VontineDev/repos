using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCaseNum = int.Parse(Console.ReadLine());

            for (int k =0; k < testCaseNum; k++)
            {
                string input = Console.ReadLine();
                string[] str = input.Split(' ');
                int replayNum = int.Parse(str[0]);

                string substr = str[1];

                for (int j = 0; j < substr.Length; j++)
                {
                    for (int i = 0; i < replayNum; i++)
                    {
                        Console.Write(substr[j]);
                    }                    
                }
                Console.WriteLine();
            }            
        }
    }
}
