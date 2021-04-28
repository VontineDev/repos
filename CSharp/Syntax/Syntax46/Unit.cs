using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax46
{
    public class Unit
    {

        //data
        //name
        //Weapon
        public string name;
        public Weapon weapon;
        public Unit(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");
        }
        //function
        //Equip
        //UnEquip
        public void Equip(Weapon weapon)
        {
            this.weapon = weapon;
            Console.WriteLine($"{this.name}이(가) {weapon.name}을 착용했습니다.");
        }
        public void UnEquip(Weapon weapon)
        {
            this.weapon = null;
            Console.WriteLine($"{this.name}이(가) {weapon.name}을 해제했습니다.");
        }
    }
}
