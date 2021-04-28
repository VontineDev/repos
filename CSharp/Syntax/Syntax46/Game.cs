using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax46
{
    public class Game
    {
        //data
        //name
        public string name;
        public Game(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");

        }
        public Unit MakeUnit(string name)
        {
            var unit = new Unit(name);

            return unit;
        }
        public Weapon MakeWeapon(string name)
        {
            var weapon = new Weapon(name);

            return weapon;
        }
    }
}
