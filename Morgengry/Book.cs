﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class Book
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

        public string ItemId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
