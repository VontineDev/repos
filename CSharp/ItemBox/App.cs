using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemBox
{
    public class App
    {
        public App()
        {
            var itemBox1 = new ItemBox("아이템 상자");
            itemBox1.GetItem("아바돈 아머(Lv.1)");
            itemBox1.Open();
        }
    }
}
