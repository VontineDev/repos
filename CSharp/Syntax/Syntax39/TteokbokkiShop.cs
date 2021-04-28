using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax39
{
    public class TteokbokkiShop
    {
        //data
        //name
        public string name;

        public TteokbokkiShop()
        {

        }

        public TTeokbokki MakeTTeokbokki(string name)
        {
            var tteokbokki = new TTeokbokki();
            tteokbokki.name = name;
            return tteokbokki;
        }
    }
}
