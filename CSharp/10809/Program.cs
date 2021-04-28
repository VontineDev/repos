using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10809
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            for (int i = 97; i < 123; i++)
            {
                Console.Write(input.IndexOf((char)i));
                Console.Write(' ');
            }
        }
    }
}