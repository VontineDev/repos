using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun
{
    public class App
    {
        public App()
        {
            var gun1 = new Gun("마이크로 우지");

            var muzzle = new Muzzle("파츠(소염기)");
            gun1.EquipMuzzle(muzzle);


            var grip = new Grip("파츠(개머리판)");
            gun1.EquipGrip(grip);


        }
    }
}
