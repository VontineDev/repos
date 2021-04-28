using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax50
{
    public class SideDish
    {
        //data
        //name
        public string name;
        public SideDish(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}가 생성되었습니다.");
            Console.WriteLine($"사이드메뉴의 이름은 {this.name} 입니다.");

        }
    }
}
