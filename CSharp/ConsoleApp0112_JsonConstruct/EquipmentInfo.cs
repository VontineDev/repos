using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0112_JsonConstruct
{
    public class EquipmentInfo
    {
        public InvenItemInfo[] arrEquipment;

        public EquipmentInfo(InvenItemInfo[] arrEquipment)
        {
            this.arrEquipment = arrEquipment;
        }
    }
}
