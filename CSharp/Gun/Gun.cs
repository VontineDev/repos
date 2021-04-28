using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun
{
    public class Gun
    {
        //data
        //name
        //part1
        //part2
        public string name;
        public Muzzle part1;
        public Grip part2;

        public Gun(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이 생성되었습니다.");
        }
        //function
        //EquipParts
        public void EquipMuzzle(Muzzle muzzle)
        {
            this.part1 = muzzle;
            Console.WriteLine($"{this.name}이 {muzzle.name}을 장착합니다.");

        }
        public void EquipGrip(Grip grip)
        {
            this.part2 = grip;
            Console.WriteLine($"{this.name}이 {grip.name}을 장착합니다.");

        }
    }
}
