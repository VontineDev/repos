using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax40
{
    public class App
    {
        public App()
        {
            var building1 = new Building();
            building1.name = "배럭스";
            Console.WriteLine($"{building1.name}이(가) 생성되었습니다.");
            var unit1 = building1.MakeUnit("마린1");
            var unit2 = building1.MakeUnit("마린2");

            unit1.Attack(unit2);

        }
    }
}
