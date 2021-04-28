using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax44
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
        //MakeCharacter
        //MakeCloth

        public Character MakeCharacter(string name)
        {
            var character = new Character(name);

            return character;
        }
        public Cloth MakeCloth(string name)
        {
            var cloth = new Cloth(name);

            return cloth;
        }
    }
}
