using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();
        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public Amulet GetAmulet(string itemId)
        {
            return amulets.Find(a => a.ItemId == itemId) ?? null;
            //foreach (Amulet amulet in amulets)
            //{
            //   if (amulet.ItemId == itemId)
            //    {
            //        return amulet;
            //    }
            //}
            //return null;
        }
        public double GetTotalValue()
        {
            return amulets.Sum(a => Utility.GetValueOfAmulet(a));
            //double result = 0;
            //foreach (Amulet amulet in amulets)
            //{
            //    result = result + Utility.GetValueOfAmulet(amulet);
            //}
            //return result;
        }
    }

}
