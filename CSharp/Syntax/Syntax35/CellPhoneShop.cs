using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax35
{
    public class CellPhoneShop
    {
        //data
        //name
        public string name;
        public CellPhoneShop(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이(가) 만들어졌습니다.");
        }
        public CellPhone MakeCellPhone(string name)
        {
            var cellPhone = new CellPhone(name);

            return cellPhone;
        }
    }
}
