using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax38
{
    public class ClothingShop
    {

        //data
        //name
        public string name;

        public ClothingShop()
        {

        }

        //function
        public Cloth MakeCloth(string name)
        {
            var cloth = new Cloth();
            cloth.name = name;
            return cloth;
        }
    }
}
