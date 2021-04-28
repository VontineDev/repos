using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax46
{
    public class App
    {
        public App()
        {
            var game1 = new Game("게임관리자");

            var unit1 = game1.MakeUnit("맥크리");
            var weapon1 = game1.MakeWeapon("리볼버");

            unit1.Equip(weapon1);
            unit1.UnEquip(weapon1);


        }
    }
}
