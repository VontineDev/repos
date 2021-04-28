using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax01
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("*** 별찍기2 ***");
            for (int i=0; i< 4; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    if (j == 0)
                    {
                        for (int k = 4; k > i; k--)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("*");
                    }
                    else
                        Console.Write("*");
                                      
                }
                Console.WriteLine();
            }
            
        }
    }
}
