using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Linq
{
    class BookData
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Bookid = 101,Name="Java programming",Pages=200,Price=120.99 },
                new Book() {Bookid = 102,Name="C# programming",Pages=180,Price=99.99 },
                new Book() {Bookid = 103,Name="php programming",Pages=220,Price=67.99 },
                new Book() {Bookid = 104,Name="Work with kotlin",Pages=250,Price=220.99 }
            };
        }
    }
}
