using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Console1013
{
    class DataLoader
    {
        private string path;

        public Dictionary<int, ItemData> LoadData(string path)
        {
            this.path = path;




            var jsonObject = File.ReadAllText(path);

            //Console.WriteLine(JsonObject);

            //역직렬화
            ItemData[] arrItemData = JsonConvert.DeserializeObject<ItemData[]>(jsonObject);

            Dictionary<int, ItemData> dicItemData = new Dictionary<int, ItemData>();
            for(int i =0; i<arrItemData.Length; i++)
            {
                var itemData = arrItemData[i];
                dicItemData.Add(itemData.id, itemData);

            }
            return dicItemData;
        }

        public void SaveData(ItemData[] itemData)
        {
            var json = JsonConvert.SerializeObject(itemData);
            Console.WriteLine(json);
            File.WriteAllText(this.path, json);

        }
    }
}
