using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax42
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
        public Monster MakeMonster(string name)
        {
            var monster = new Monster(name);
            return monster;
        }

        public Crop MakeCrop(string name)
        {
            var crop = new Crop(name);
            return crop;
        }
    }
}
