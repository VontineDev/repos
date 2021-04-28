using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            for (int i =0; i<1; i++)
            {
                var a1 = r.Next(1, 46);
                Console.Write(a1);
                Console.Write("\t");
                var a2 = r.Next(1, 46);
                Console.Write(a2);
                Console.Write("\t");
                var a3 = r.Next(1, 46);
                Console.Write(a3);
                Console.Write("\t");
                var a4 = r.Next(1, 46);
                Console.Write(a4);
                Console.Write("\t");
                var a5 = r.Next(1, 46);
                Console.Write(a5);
                Console.Write("\t");
                float a6 = r.Next(1, 46);
                Console.Write(a6);
                Console.Write("\t");



            }
        }
    }
}
