using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
   
    public class Character
    {
        //data
        //name
        //bow
        //arrow
        public string name;
        public Bow bow;
        public Arrow arrow;
        public Character(string name)
        {
            this.name = name;
        }
        //function
        //Shoot
        //Equip
        public void Shoot(Target target)
        {
            Console.WriteLine($"{this.name}가 {target.name}에게 활을 쏩니다.");

            target.Hit(this);
        }
        public void EquipBow(Bow bow)
        {
            this.bow = bow;
            Console.WriteLine($"{this.name}가 {bow.name}을 착용합니다.");
        }
        public void EquipArrow(Arrow arrow)
        {
            this.arrow = arrow;
            Console.WriteLine($"{this.name}가 {arrow.name}을 착용합니다.");
        }


    }
}
