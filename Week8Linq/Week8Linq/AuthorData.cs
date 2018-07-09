using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Linq
{
    public class AuthorData
    {
        public IEnumerable<Author> GetAuthors()
        {
            return new List<Author>
            {
                new Author() {Authorid=110,AuthName="ABC", Designation="A1",Bookid=101 },
                new Author() {Authorid=111,AuthName="John", Designation="B1",Bookid=102 },
                new Author() {Authorid=112,AuthName="Mary", Designation="C1",Bookid=103 },
                new Author() {Authorid=113,AuthName="Smith", Designation="D1",Bookid=104 }
            };
        }
    }
}
