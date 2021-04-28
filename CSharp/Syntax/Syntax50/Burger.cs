using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax50
{
    public class Burger
    {
        //data
        //name
        public string name;
        public Burger(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}가 생성되었습니다.");

            Console.WriteLine($"버거의 이름은 {this.name} 입니다.");

        }
    }
}
