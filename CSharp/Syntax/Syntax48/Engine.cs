using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax48
{
    public class Engine
    {

        //data
        //name
        public string name;
        public Engine(string name)
        {
            this.name = name;
            Console.WriteLine($"엔진 ({this.name})이(가) 생성되었습니다.");
            Console.WriteLine($"엔진의 이름은 {this.name} 엔진 입니다.");
        }

    }
}
