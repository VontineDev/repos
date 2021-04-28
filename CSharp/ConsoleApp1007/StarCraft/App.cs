using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    public class App
    {
        public App()
        {
            

            Unit headQuarter1 = new Unit("해처리", new Position(0,-2));
            

            var unit1 = new Unit("드론1", new Position(-1, 4));
            var unit2 = new Unit("드론2", new Position(1, -4));
            var unit3 = new Unit("드론3", new Position(2, -4));
            var unit4 = new Unit("드론4", new Position(0, 4));

            var unit5 = new Unit("오버로드", new Position(3, -5));

            var unit6 = new Unit("라바1", new Position(-1, 4));
            var unit7 = new Unit("라바2", new Position(1, -4));
            var unit8 = new Unit("라바3", new Position(0, -4));


        }
    }
}
