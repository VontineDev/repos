using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1013
{
    class Test
    {
        private DataLoader dataLoader;

        public void Run()
        {
            string fileName = "item_data.json";
            string filePath = string.Format($"C:/Users/Jin/source/repos/Console1013/{fileName}");

            this.dataLoader = new DataLoader();
            var dicItemData = this.dataLoader.LoadData(filePath);

            dicItemData[100].damage = 500;
            dicItemData[100].name = "장검";
            var arrItemData = new ItemData[dicItemData.Count];
            int idx = 0;
            foreach (var keyValue in dicItemData)
            {
                var itemData = new ItemData();
                itemData.id = keyValue.Value.id;
                itemData.name = keyValue.Value.name;
                itemData.damage = keyValue.Value.damage;
                arrItemData[idx] = itemData;
                idx++;
            }

            this.dataLoader.SaveData(arrItemData);

        }
    }
}
