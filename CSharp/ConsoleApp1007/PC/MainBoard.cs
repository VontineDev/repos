using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    public class MainBoard
    {
        //data
        //name
        string name;
        public MainBoard(string name)
        {
            this.name = name;
        }
        public string GetMainBoardName()
        {
            return this.name;
        }

    }
}
