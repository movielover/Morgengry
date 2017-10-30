using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(string itemId)
        {
            return books.Find(b => b.ItemId == itemId) ?? null;
            //foreach (Book book in books)
            //{
            //    if (book.ItemId== itemId)
            //    {
            //        return book;
            //    }
            //}
            //return null;
        }
        public double GetTotalValue()
        {
            return books.Sum(b => Utility.GetValueOfBook(b));
            //double result = 0;
            //foreach (Book book in books)
            //{
            //   result = result + Utility.GetValueOfBook(book);
            //}
            //return result;
        }
    }
}
