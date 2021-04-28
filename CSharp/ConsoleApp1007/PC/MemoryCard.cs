using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    public class MemoryCard
    {
        //data
        //name
        string name;
        public MemoryCard(string name)
        {
            this.name = name;
        }
        public string GetMemoryCardName()
        {
            return this.name;
        }
    }
}
