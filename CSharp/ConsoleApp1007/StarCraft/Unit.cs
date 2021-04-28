using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    public class Unit
    {
        //data
        //name
        //hp
        //coordinate
        public string name;
        public int hp;
        public int maxHp;
        public Position position;

        public Unit(string name, Position position)
        {
            this.position = position;
            this.name = name;
            Console.WriteLine($"{this.name} ({this.position.x},{this.position.y})가 생성되었습니다.");

        }
        
    }
}
