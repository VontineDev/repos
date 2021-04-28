using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax47
{
    public class App
    {
        public App()
        {
            var game1 = new Game("게임관리자");

            var champion1 = game1.MakeChampion("루시안");
            var skill1 = game1.MakeSkill("빛의 심판");

            champion1.GetSkill(skill1);
            champion1.UseSkill();


            
        }

    }
}
