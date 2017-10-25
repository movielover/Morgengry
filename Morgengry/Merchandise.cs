using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public abstract class Merchandise
    {

        public string ItemId { get; set; }
        public override string ToString()
        {
            return String.Format("ItemId: {0}", ItemId);
        }
    }
    
}
