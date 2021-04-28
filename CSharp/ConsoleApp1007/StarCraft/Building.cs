using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarCraft
{
    public class Building
    {
        //data
        //name
        //position
        public string name;
        public Position position;
        public Building(string name, Position position)
        {
            this.position = position;
            this.name = name;
        }
        //function
        //SelectLarva
        public void SelectLarva()
        {

        }
    }
}
