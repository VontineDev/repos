using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    public class App
    {
        public App()
        {
            SpaceShip spaceShip1 = new SpaceShip("슈퍼 에이스");

            spaceShip1.Shoot();
            spaceShip1.Shoot();
            spaceShip1.Shoot();
        }
    }
}
