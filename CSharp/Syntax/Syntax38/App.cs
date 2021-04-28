using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax38
{
    public class App
    {
        
        public App()
        {
            var clothingShop1 = new ClothingShop();
            clothingShop1.name = "ZARA";

            Console.WriteLine($"{clothingShop1.name}이(가) 만들어졌습니다.");

            var cloth1 = clothingShop1.MakeCloth("아우터");
            var cloth2 = clothingShop1.MakeCloth("자켓");
            var cloth3 = clothingShop1.MakeCloth("원피스");

            Console.WriteLine($"{cloth1.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{cloth2.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{cloth3.name}이(가) 만들어졌습니다.");


        }
    }
}
