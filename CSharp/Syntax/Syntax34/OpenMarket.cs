using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax34
{
    public class OpenMarket
    {
        //data
        //name
        public string name;
        public OpenMarket(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 만들어졌습니다.");
        }
        public Product MakeProduct(string name)
        {
            var product = new Product(name);
            return product;
        }
    }
}
