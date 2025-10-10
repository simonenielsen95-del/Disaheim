using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {

        
        public string Design;
        public Level Quality;
       

        public Amulet(string itemId)
            //: base(itemId)
        {
            ItemId = itemId;
            Design = "";
            Quality = Level.Medium;
        }

        public Amulet(string itemId, Level quality)
            //: base(itemId)
        {
            ItemId = itemId;
            Design = "";
            Quality = quality;           
        }

        public Amulet(string itemId, Level quality, string design)
            //: base(itemId) 
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
