using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax47
{
    public class Skill
    {
        //data
        //name
        public string name;
        public Skill(string name)
        {
            this.name = $"스킬({name})";
            Console.WriteLine($"{this.name}이 생성되었습니다.");

        }
    }
}
