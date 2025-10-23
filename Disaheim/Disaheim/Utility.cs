using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

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
        public double GetValueOfCourse(Course course)
        {
            if (course.DurationInMinutes % 60 == 0) // er sand hvis divitionen går op uden rest. 
                return (course.DurationInMinutes / 60) * 875;
            else
                return ((course.DurationInMinutes / 60) + 1) * 875; //runder op med +1, eller  (minuets + 59) / 60 * 875. "runder op ved at tilføje 59 til antal minutter.
        }
    }    
}
