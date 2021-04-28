using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax41
{
    public class App
    {
        public App()
        {
            var game1 = new Game("게임관리자");

            var unit1 = new Unit("이즈리얼");
            var unit2 = new Unit("티모");

            unit1.Attack(unit2);


        }
    }
}

