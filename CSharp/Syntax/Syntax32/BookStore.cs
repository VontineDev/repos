using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax32
{
    public class BookStore
    {
        //데이터
        //이름
        public string name;

        public BookStore()
        {

        }

        public Book MakeBook(string name)
        {
            var book = new Book();
            book.name = name;
            return book;
        }
    }
}
