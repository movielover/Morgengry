﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class Amulet
    {
        public Amulet(string itemId, Level quality, string design )
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
        }
        public Amulet(string itemId, Level quality) :
            this(itemId, quality, "")
        {  
        }
        public Amulet(string itemId):
            this(itemId, Level.medium, "")
        {
        }
        public string ItemId { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }
        
    }
}