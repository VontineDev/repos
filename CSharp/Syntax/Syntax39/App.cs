using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax39
{
    public class App
    {
        public App()
        {
            var tteokbokkiShop1 = new TteokbokkiShop();
            tteokbokkiShop1.name = "이웃집소녀떡볶이";

            Console.WriteLine($"{tteokbokkiShop1.name}이(가) 만들어졌습니다.");

            var tteokbokki1 = tteokbokkiShop1.MakeTTeokbokki("달콤이");
            var tteokbokki2 = tteokbokkiShop1.MakeTTeokbokki("달볶이");
            var tteokbokki3 = tteokbokkiShop1.MakeTTeokbokki("이소떡");

            Console.WriteLine($"{tteokbokki1.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{tteokbokki2.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{tteokbokki3.name}이(가) 만들어졌습니다.");

        }
    }
}
