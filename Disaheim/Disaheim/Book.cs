using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        public string ItemId;
        public string Title;
        public double Price;
 

        public Book(string itemId)
        { 
            ItemId = itemId;
            Title = "";
            Price = 0;        
        }
        public Book(string itemId, string title)
        {
            ItemId = itemId;
            Title = title;
            Price = 0;
        }

        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
        
    }   

}
