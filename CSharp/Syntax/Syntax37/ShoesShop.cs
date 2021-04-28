using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax37
{
    public class ShoesShop
    {
        //data
        //name
        public string name;

        public ShoesShop(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 만들어졌습니다.");
        }

        //fuction
        public Shoes MakeShoes(string name)
        {
            var shoes = new Shoes(name);
            return shoes;
        }
    }
}
