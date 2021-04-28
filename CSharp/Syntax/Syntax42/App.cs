using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax42
{
    public class App
    {
        public App()
        {
            var game1 = new Game("게임 관리자");

            var monster1 =game1.MakeMonster("쥐");
            var crop1 = game1.MakeCrop("호박");

            monster1.Attack(crop1);
        }
    }
}
