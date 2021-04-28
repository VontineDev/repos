using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax47
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

        //function
        //MakeChmapion
        //MakeSkill
        public Champion MakeChampion(string name)
        {
            var champion = new Champion(name);
            return champion;
        }
        public Skill MakeSkill(string name)
        {
            var skill = new Skill(name);
            return skill;
        }

    }
}
