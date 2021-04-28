using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemBox
{
    public class ItemBox
    {
        //data
        //name
        //item
        public string name;
        public Item item;
        public ItemBox(string name)
        {
            this.name = name;
            Console.WriteLine($"{this.name}이 생성되었습니다.");
        }
        //function
        //Open
        public void Open()
        {
            Console.WriteLine($"{this.name}을 열었습니다.");
            Console.WriteLine($"{this.item.name}이 나왔습니다.");

        }
        public void GetItem(string name)
        {
            item = new Item(name);

        }

    }
}
