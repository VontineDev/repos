using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax44
{
    public class Cloth
    {
        //data
        //name
        public string name;
        public Cloth(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");

        }

    }
}
