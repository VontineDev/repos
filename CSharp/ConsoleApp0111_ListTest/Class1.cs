using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0111_ListTest
{
    public class Class1
    {
        public Class1()
        {
            List<ItemInfo> list = new List<ItemInfo>();

            var item1 = new ItemInfo(0, 101);
            var item2 = new ItemInfo(1, 102);
            var item3 = new ItemInfo(2, 103);
            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
                     
            foreach(var item in list)
            {
                Console.WriteLine($"{item.slot_id}/{item.item_id}");
            }

            list.Remove(item1);

            Console.WriteLine("AfterRemove");


            foreach (var item in list)
            {
                Console.WriteLine($"{item.slot_id}/{item.item_id}");
            }

            Console.WriteLine("===================");


            var foundItem = (from aa in list
                            where aa.slot_id == 1
                            select aa).FirstOrDefault();
            list.Remove(foundItem);
            
            foreach (var item in list)
            {
                Console.WriteLine($"{item.slot_id}/{item.item_id}");
            }

        }
    }
}
