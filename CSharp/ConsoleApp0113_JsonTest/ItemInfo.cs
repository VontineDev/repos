using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0113_JsonTest
{
    public class ItemInfo
    {
        public string guid;
        public int item_id;
        public int amount;
        public ItemInfo(string guid, int item_id, int amount)
        {
            this.guid = guid;
            this.item_id = item_id;
            this.amount = amount;
        }
    }
}
