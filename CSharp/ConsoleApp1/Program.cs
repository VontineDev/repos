using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int k = 1; k < 4; k++)
            {
                if (k < 2)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        for (int j = 2; j < 5; j++)
                        {
                            Console.Write(String.Format("{0,1} x {1,1} = {2,2}    ", j, i, (i * j)));
                        }
                        Console.WriteLine();
                    }
                }
                else if (k<3)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        for (int j = 5; j < 8; j++)
                        {
                            Console.Write(String.Format("{0,1} x {1,1} = {2,2}    ", j, i, (i * j)));
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = 1; i < 10; i++)
                    {
                        for (int j = 8; j < 10; j++)
                        {
                            Console.Write(String.Format("{0,1} x {1,1} = {2,2}    ", j, i, (i * j)));
                        }
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
            }
        }
     
    }
}
