using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;



namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets { get; set; }

        public AmuletRepository()
        {
            amulets = new List<Amulet>();
        }

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            for (int i = 0; i < amulets.Count; i++)
            {
                if (amulets[i].ItemId == itemId)
                { return amulets[i]; }
            }
            return null;

        }

        public double GetTotalValue()
        {
            double total = 0;
            Utility utility = new Utility();
            foreach (Amulet amulet in amulets)
            {
                total += utility.GetValueOfAmulet(amulet);
            }
            return total;
        }

    }
}

