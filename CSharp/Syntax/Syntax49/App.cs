using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax49
{
    public class App
    {
        public App()
        {
            var pc1 = new PC("PC");

            pc1.GetGraphicCard("GT730");
            pc1.GetCPU("라이젠 3");

        }
    }
}
