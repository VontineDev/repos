using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax36
{
    public class App
    {
        public App()
        {
            var laptopShop1 = new LaptopShop();
            laptopShop1.name = "삼성";
            Console.WriteLine($"{laptopShop1.name}이(가) 만들어졌습니다.");

            var laptop1 = laptopShop1.MakeLaptop("노트북 Pen");
            var laptop2 = laptopShop1.MakeLaptop("노트북 9");
            var laptop3 = laptopShop1.MakeLaptop("노트북 오디세이");

            Console.WriteLine($"{laptop1.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{laptop2.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{laptop3.name}이(가) 만들어졌습니다.");

        }
    }
}
