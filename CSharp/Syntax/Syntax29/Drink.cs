using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax29
{
    public class Drink
    {
        //데이터
        //이름
        public string name;
        public Drink(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 나왔습니다.");
        }
    }
}
