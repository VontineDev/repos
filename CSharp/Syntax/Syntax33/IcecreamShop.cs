using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax33
{
    public class IcecreamShop
    {
        //데이터
        //이름
        public string name;
        public IcecreamShop(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 만들어졌습니다.");
        }
        public Icecream MakeIcecream(string name)
        {
            var icecream = new Icecream(name);
           
            return icecream;
        }
    }
}
