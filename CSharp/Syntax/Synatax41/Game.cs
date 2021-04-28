using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax41
{
    public class Game
    {
        //data
        //name
        public string name;
        public Game(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이 생성되었습니다.");
        }

        public Unit MakeUnit(string name)
        {
            var unit = new Unit(name);

            return unit;

        }
    }
}
