using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApp0113_JsonTest
{
    public class App
    {
        public App()
        {
            var item1 = new ItemInfo(Guid.NewGuid().ToString(), 100, 1);
            var item2 = new ItemInfo(Guid.NewGuid().ToString(), 101, 1);
            var item3 = new ItemInfo(Guid.NewGuid().ToString(), 102, 1);
            var item4 = new ItemInfo(Guid.NewGuid().ToString(), 103, 1);

            List<ItemInfo> list = new List<ItemInfo>();

            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);

            UserInfo userInfo = new UserInfo(0, "user0", 1, 1, list);


            string json = JsonConvert.SerializeObject(userInfo);

            Console.WriteLine(json);

            //string json2 = JsonConvert.SerializeObject(list);

            //Console.WriteLine(json2);


        }
    }
}
