using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax43
{
    public class Resource
    {
        //data
        //name
        //gold 100ea
        public string name;
        public int gold = 100;
        public Resource(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이 생성되었습니다.");
        }
    }
}
