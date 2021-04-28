using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax37
{
    public class App
    {
        public App()
        {
            var shoesShop1 = new ShoesShop("나이키");

            var shoes1 = shoesShop1.MakeShoes("에어멕스");
            var shoes2 = shoesShop1.MakeShoes("모나크");
            var shoes3 = shoesShop1.MakeShoes("에어포스");
        }
    }
}
