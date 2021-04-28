using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    public class Bullet
    {
        //data
        //name
        //description
        //damage
        public string name;
        public string description;
        public int damage;

        public Bullet()
        {
          

        }
        //function
        //Move
        public void Move()
        {
            Console.WriteLine($"{this.name}이 직선으로 이동했습니다");
        }
    }
}
