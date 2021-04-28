using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax30
{
    public class App
    {
        public App()
        {
            var bakery1 = new Bakery();
            bakery1.name = "파리바게트";
            Console.WriteLine($"{bakery1.name}이(가) 만들어졌습니다.");

            var bread1 = bakery1.MakeBread("소보루빵");
            
            var bread2 = bakery1.MakeBread("우유식빵");
           
            var bread3 = bakery1.MakeBread("단팥빵");
           
            Console.WriteLine($"{bread1.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{bread2.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{bread3.name}이(가) 만들어졌습니다.");

        }
    }
}
