using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax32
{
    public class App
    {
        public App()
        {
            var bookstore1 = new BookStore();
            bookstore1.name = "교보문고";
            Console.WriteLine($"{bookstore1.name}이(가) 만들어졌습니다.");
            var book1 = bookstore1.MakeBook("이것이C#이다");
            var book2 = bookstore1.MakeBook("열혈자료구조");
            var book3 = bookstore1.MakeBook("해리포터");

            Console.WriteLine($"{book1.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{book2.name}이(가) 만들어졌습니다.");
            Console.WriteLine($"{book3.name}이(가) 만들어졌습니다.");

        }
    }
}
