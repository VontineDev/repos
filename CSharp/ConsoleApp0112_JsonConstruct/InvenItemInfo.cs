﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0112_JsonConstruct
{
    public class InvenItemInfo
    {
        public int slot_id;
        public int item_id;
        public InvenItemInfo(int slot_id, int item_id)
        {
            this.slot_id = slot_id;
            this.item_id = item_id;
        }
    }
}
