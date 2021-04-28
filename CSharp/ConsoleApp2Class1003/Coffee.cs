using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Class1003
{
    public class Coffee
    {
        //data
        //name
        public string name;
        public Coffee(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이 생성되었습니다.");

        }
    }
}
