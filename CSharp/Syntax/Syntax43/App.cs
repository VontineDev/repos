using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax43
{
    public class App
    {
        public App()
        {
            var game1 = new Game("게임 관리자");

            var resource1 = new Resource("금광");
            var unit1 = new Unit("광부");
            unit1.VeinMine(resource1);

        }
    }
}
