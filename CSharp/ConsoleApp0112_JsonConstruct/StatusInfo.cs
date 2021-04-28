using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0112_JsonConstruct
{
    public class StatusInfo
    {
        public int id;
        public float dmg;
        public float atkSpeed;

        public StatusInfo(int id, float dmg, float atkSpeed)
        {
            this.id = id;
            this.dmg = dmg;
            this.atkSpeed = atkSpeed;
        }
    }
}
