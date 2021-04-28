using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax47
{
    public class Champion
    {
        //data
        //name
        //skill
        public string name;
        public Skill skill;   
        public Champion(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 생성되었습니다.");
        }
        //function
        //GetSkill
        //UseSkill
        public void GetSkill(Skill skill)
        {
            this.skill = skill;
            Console.WriteLine($"{this.name}이(가) {skill.name}을 부여받았습니다.");

        }
        public void UseSkill()
        {
           
            Console.WriteLine($"{this.name}이(가) {this.skill.name}을 사용했습니다.");

        }

    }
}
