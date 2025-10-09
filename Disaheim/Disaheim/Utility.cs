using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        
        public double GetValueOfAmulet(Amulet amulet)
        {
            if (amulet.Quality == Level.Low)
                return 12.5;
            if (amulet.Quality == Level.Medium)
                return 20;
            else // retunere hvis kvaliteten er høj.
                return 27.5;

        }
    }

    
}
