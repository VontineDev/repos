using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax46
{
    public class Weapon
    {
        //data
        //name
        public string name;
        public Weapon(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");

        }
    }
}
