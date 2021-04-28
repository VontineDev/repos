using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax28
{



    
    public class Pizza
    {
        public string name;
        //생성자 메서드 또는 생성자 라고부른다
        public Pizza(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 만들어졌습니다.");
          
        }
    }
}
