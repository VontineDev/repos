using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("연도를 입력하세요. 윤년이면1, 아니면0 이 나옵니다. ");
            int year = Int32.Parse(Console.ReadLine());

            if ( (year%4==0 && year%100 !=0) || year%400==0)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

    }
}