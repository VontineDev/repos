using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax34
{
    public class App
    {
        public App()
        {
            var openMarket1 = new OpenMarket("G마켓");

            var product1 = openMarket1.MakeProduct("비타민C스틱");
            var product2 = openMarket1.MakeProduct("아기 물티슈");
            var product3 = openMarket1.MakeProduct("후드티");

        }
    }
}
