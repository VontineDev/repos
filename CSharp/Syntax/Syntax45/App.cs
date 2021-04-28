using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax45
{
    public class App
    {
        public App()
        {
            var game1 = new Game("게임관리자");

            var unit1 = game1.MakeUnit("톰");
            var unit2 = game1.MakeUnit("제리");

            unit1.Attack(unit2);

        }
    }
}
