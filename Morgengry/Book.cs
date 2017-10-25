using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book: Merchandise
    {
        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }
        public Book(string itemId, string title):
            this(itemId, title, 0)
        {
        }
        public Book(string itemId):
            this(itemId, "", 0)
        {
        }

        public string Title { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return String.Format("ItemId: {0}, Title: {1}, Price: {2}", ItemId, Title, Price);
        }
    }
}
