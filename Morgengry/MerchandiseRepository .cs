using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class MerchandiseRepository
    {
        private List<Amulet> amulets = new List<Amulet>();
        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public Amulet GetAmulet(string itemId)
        {
            foreach (Amulet amulet in amulets)
            {
                if (amulet.ItemId == itemId)
                {
                    return amulet;
                }
            }
            return null;
        }
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(string itemId)
        {
            foreach (Book book in books)
            {
                if (book.ItemId == itemId)
                {
                    return book;
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double result = 0;
            foreach (Amulet amulet in amulets)
            {
                result = result + Utility.GetValueOfAmulet(amulet);
            }
            foreach (Book book in books)
            {
                result = result + Utility.GetValueOfBook(book);
            }
            return result;
        }
        
}
}
