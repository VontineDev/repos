using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2908
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputnum = Console.ReadLine().Split();

            var str1 = new string(inputnum[0].ToCharArray().Reverse().ToArray());
            var str2 = new string(inputnum[1].ToCharArray().Reverse().ToArray());

            if (int.Parse(str1) > int.Parse(str2))
            {
                Console.WriteLine(str1);

            }
            else
            {
                Console.WriteLine(str2);

            }


        }
    }
}
