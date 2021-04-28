using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC
{
    public class SoundCard
    {
        //data
        //name
        string name;
        public SoundCard(string name)
        {
            this.name = name;
        }
        public string GetSoundCardName()
        {
            return this.name;
        }
    }
}
