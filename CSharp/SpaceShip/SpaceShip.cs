using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShip
{
    public class SpaceShip
    {
        //data
        //name
        public string name;
        public int number=1;
        public SpaceShip(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}가 생성되었습니다.");


        }
        //function
        //Shoot
        public void Shoot()
        {
            var bullet = new Bullet();
            
            bullet.name = "총알" + number;
            number++;

            Console.WriteLine($"{this.name}이 총을 쐈습니다.");

            bullet.Move();
        }

    }
}
