using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0113_JsonTest
{
   public class UserInfo
    {
        public int user_id;
        public string user_name;
        public int heroDamageLv;
        public int heroAtkSpeedLv;
        public List<ItemInfo> item_info;

        public UserInfo(int user_id, string user_name, int heroDamageLv, int heroAtkSpeedLv, List<ItemInfo> item_info)
        {
            this.user_id = user_id;
            this.user_name = user_name;
            this.heroDamageLv = heroDamageLv;
            this.heroAtkSpeedLv = heroAtkSpeedLv;
            this.item_info = item_info;
        }
    }
}
