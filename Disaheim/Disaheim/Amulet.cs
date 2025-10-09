using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {

        public string ItemId;        
        public string Design;
        public Level Quality;
       

        public Amulet(string itemId)
        {
            ItemId = itemId;
            Design = "";
            Quality = Level.Medium;
        }

        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId;
            Design = "";
            Quality = quality;           
        }

        public Amulet(string itemId, Level quality, string design)
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
