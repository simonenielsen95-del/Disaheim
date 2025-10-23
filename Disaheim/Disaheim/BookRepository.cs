using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using Disaheim;

namespace Disaheim
{
    public class BookRepository
    {

        private List<Book> books { get; set; }

        public BookRepository()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBook(string itemId)
        {
            for (int i = 1; i < books.Count; i++)
            {
                if (books[i].ItemId == itemId)
                { return books[i]; }
            }
            return null;

        }

        public double GetTotalValue()
        {
            double total = 0;
            Utility utility = new Utility();
            foreach (Book book in books)
            {
                total += utility.GetValueOfBook(book);
            }
            return total;
        }

    }
}
