using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax09
{
    class Program
    {
        static void Main(string[] args)
        {
            int col, row;
            Console.Write("Col : ");
            col = Int32.Parse(Console.ReadLine());
            Console.Write("Row : ");
            row = Int32.Parse(Console.ReadLine());

            for(int i = 0 ; i < row ; i++)
            {
                for(int j = 0 ; j < col ; j++ )
                {
                    Console.Write($"({j},{i})\t");
                }
                Console.WriteLine();
            }
        }
    }
}
