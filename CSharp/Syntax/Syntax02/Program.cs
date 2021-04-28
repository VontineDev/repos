using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("구구단중에 원하는 단을 입력해주세요. ");
            string input = Console.ReadLine();
               
            int num = Convert.ToInt32(input);
              
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
               
            }

            
        }
    }
}
