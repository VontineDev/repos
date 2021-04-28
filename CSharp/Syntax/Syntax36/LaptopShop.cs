using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax36
{
    public class LaptopShop
    {
        //data
        //name
        public string name;
        public LaptopShop()
        {

        }
        public Laptop MakeLaptop(string name)
        {
            var laptop = new Laptop();
            laptop.name = name;

            return laptop;
        }
    }
}
