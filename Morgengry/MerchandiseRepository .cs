using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{ public class MerchandiseRepository
{
    private List<Merchandise> merchandise = new List<Merchandise>();
    public void AddAmulet(Amulet amulet)
    {
        merchandise.Add(amulet);
    }
    public void AddBook(Book book)
    {
        merchandise.Add(book);
    }
    public Amulet GetAmulet(string itemId)
        {
            foreach (Amulet amulet in merchandise)
            {
                if (amulet.ItemId == itemId)
                {
                    return amulet;
                }
            }
            return null;
        }
        public Book GetBook(string itemId)
        {
            foreach (Book book in merchandise)
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
            foreach (Amulet amulet in merchandise)
            {
                result = result + Utility.GetValueOfAmulet(amulet);
            }
            foreach (Book book in merchandise)
            {
                result = result + Utility.GetValueOfBook(book);
            }
            return result;
        }
        }
    }

