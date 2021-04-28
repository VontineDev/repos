using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax12
{

    class Program
    {
        static void Main(string[] args)
        {
           int sum=0;
            for (int i = 1; i <=20; i++)
            {
                if (i % 3 == 0 && i % 6 == 0)
                {
                    sum = sum + i;
                }                    
            }
            Console.WriteLine(sum);
        }
    }
}
