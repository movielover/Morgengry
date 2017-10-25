using System;

namespace Morgengry
{
    public class Amulet:Merchandise
    {
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
        }
        public Amulet(string itemId, Level quality) :
            this(itemId, quality, "")
        {
        }
        public Amulet(string itemId) :
            this(itemId, Level.medium, "")
        {
        }

        public string Design { get; set; }
        public Level Quality { get; set; }
        public override string ToString()
        {
            return String.Format("ItemId: {0}, Quality: {1}, Design: {2}", ItemId, Quality, Design);
        } 

    }
}
