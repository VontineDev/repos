using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ConsoleApp0112_JsonConstruct
{
    public class App
    {
        public App()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.id = 1;
            userInfo.userName = "user1";

            
            InvenItemInfo item1 = new InvenItemInfo(90, 101);
            InvenItemInfo item2 = new InvenItemInfo(91, 102);
            InvenItemInfo item3 = new InvenItemInfo(92, 103);
            InvenItemInfo item4 = new InvenItemInfo(93, 104);

            InvenItemInfo[] invenItemInfo = { item1, item2, item3, item4 };
           
            var equipmentInfo = new EquipmentInfo(invenItemInfo);

            userInfo.equipment_info = equipmentInfo;

            StatusInfo statusInfo = new StatusInfo(0, 100, 100);

            userInfo.status_info = statusInfo;

            List<InvenItemInfo> list = new List<InvenItemInfo>();

            for(int i =0; i<20; i++)
            {
                list.Add(new InvenItemInfo(i, 100 + (i % 7+1)));
            }

            ItemInfo itemInfo = new ItemInfo();

            itemInfo.invenItems = list;

            userInfo.items_info = itemInfo;

            //Console.WriteLine(userInfo);

            var json = JsonConvert.SerializeObject(userInfo);

            Console.WriteLine(json);            
        }
    }
}
