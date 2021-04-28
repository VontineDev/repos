using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax35
{
    public class App
    {
        public App()
        {
            var cellPhoneShop1 = new CellPhoneShop("Apple");

            var cellPhone1 = cellPhoneShop1.MakeCellPhone("iPhone 11Pro");
            var cellPhone2 = cellPhoneShop1.MakeCellPhone("iPhone 11");
            var cellPhone3 = cellPhoneShop1.MakeCellPhone("iPhone 11 Xr");
        }
    }
}
