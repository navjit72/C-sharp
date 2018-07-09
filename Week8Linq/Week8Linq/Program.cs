using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookData = new BookData().GetBooks();
            var authorData = new AuthorData().GetAuthors();
            List<Book> bookList = (List<Book>)bookData;
            List<Author> authorList = (List<Author>)authorData;

            //Join with query operators
            var auth_book = from book in bookList
                            join auth in authorList
                            on book.Bookid equals auth.Bookid
                            select new
                            {
                                book.Bookid,
                                book.Name,
                                auth.AuthName,
                                auth.Authorid
                            };

            var ab = auth_book.Distinct();
            //foreach(var a in auth_book)
            //{
            //    Console.WriteLine("Book :" + a.Bookid + " " + a.Name);
            //    Console.WriteLine("Author : " + a.Authorid + " " + a.AuthName);
            //}

            //var books = bookData.Select(b => new { b.Name, b.Price });

            //foreach(var b in  books)
            //{
            //    Console.WriteLine(b.Name);
            //}

            //foreach (Author author in authorList)
            //{
            //    Console.Write(author.Authorid);
            //    Console.Write(" " + author.Name);
            //    Console.Write(" " + author.Designation);
            //    Console.Write(" " + author.Bookid);
            //    Console.WriteLine();
            //}

            //without LINQ
            //var cheapBooks = new List<Book>();
            //foreach(Book book in bookData)
            //{
            //    if (book.Price < 100)
            //        cheapBooks.Add(book);
            //}

            //LINQ with lambda exp
            //var cheapBooks = bookData
            //                 .Where(b => b.Price < 100)
            //                 .OrderBy(b => b.Price)
            //                 .Select(b => b.Name);

            //foreach (Book book in cheapBooks)
            //{
            //    Console.Write(book.Bookid);
            //    Console.Write(" " + book.Name);
            //    Console.Write(" " + book.Pages);
            //    Console.Write(" " + book.Price);
            //    Console.WriteLine();
            //}

            //LINQ with query operators
            //var cheapBooks = from b in bookData
            //                 where b.Price < 100
            //                 orderby b.Price
            //                 select b.Name;
            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book);
            //}

            //LINQ with query operators
            //var firstBook = bookData.First();
            //Console.WriteLine(firstBook.Name + " " + firstBook.Price);

            //var singleBook = bookData.SingleOrDefault(b => b.Name == "Java Programming1");
            //if(singleBook!=null)
            //    Console.WriteLine(singleBook.Bookid + " " + singleBook.Name);
            //else
            //    Console.WriteLine("Book not found");

            //if multiple values are returned it is returning the first value.
            //var fbook = bookData.First(b => b.Name == "Java programming");

            //var books = bookData.SkipWhile(b => b.Bookid == 102);

            //foreach(Book b in books)
            //{
            //    Console.WriteLine(b.Name);
            //}

            //Aggregate functions
            //var count = bookData.Count();
            //Console.WriteLine("Count : " + count);

            //var avgPrice = bookData.Average(b => b.Price);
            //Console.WriteLine("Average : " + avgPrice);

            //var minBook = bookData
            //                       .Where(b => b.Price == (bookData.Min(c => c.Price)))
            //                       .Select(b => b.Name);

            //foreach (var d in minBook)
            //{

            //    Console.WriteLine("Book with min price : " + d);
            //}

            //var maxBook = bookData
            //                       .Where(b => b.Price == (bookData.Max(c => c.Price)))
            //                       .Select(b => b.Name);

            //foreach (var d in maxBook)
            //{

            //    Console.WriteLine("Book with min price : " + d);
            //}

            //foreach (Author author in authorData)
            //{
            //    Console.Write(author.Authorid);
            //    Console.Write(" " + author.Name);
            //    Console.Write(" " + author.Designation);
            //    Console.Write(" " + author.Bookid);
            //    Console.WriteLine();
            //}
            Console.Read();
        }
    }
}
