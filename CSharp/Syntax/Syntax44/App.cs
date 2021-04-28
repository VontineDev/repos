using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax44
{
    public class App
    {
        public App()
        {
            var game1 = new Game("게임 관리자");

            var character1 = game1.MakeCharacter("쥬쥬");
            var cloth1 = game1.MakeCloth("원피스");

            character1.PutOnCloth(cloth1);

        }
    }
}
