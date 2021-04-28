using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public class App
    {
        public App()
        {
            var character1 = new Character("아쳐");
            var bow1 = new Bow("어둠활");
            var arrow1 = new Arrow("암흑 화살");
            var target1 = new Target("표적");


            character1.EquipBow(bow1);
            character1.EquipArrow(arrow1);

            character1.Shoot(target1);

        }
    }
}
