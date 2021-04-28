using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("줄넘기횟수를 입력해주세요.");
            string count = Console.ReadLine();
            Console.WriteLine("입력한 줄넘기 횟수는 " + count + "번 입니다.");
            int c = Int32.Parse(count);
            Console.WriteLine(c);
        }
    }
}
