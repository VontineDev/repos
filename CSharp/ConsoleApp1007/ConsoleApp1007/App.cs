using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1007
{
    public class App
    {
        public App()
        {
            var building1 = new Building("게이트웨이");

            var unit1 = building1.MakeUnit("질롯", 10, 3, 5);
            var unit2 = building1.MakeUnit("드라군", 15, 4, 8);

            unit1.Attack(unit2, 7);

            unit2.Attack(unit1, 7);
        }
    }
}
