
using System.Collections.Generic;
using System.Linq;


namespace HarryPotter
{
    public class Basket
    {
        IList<Book> books;
        public Basket(IEnumerable<Book> books)
        {
            this.books = books.ToList();
        }

        public int HowMany(Book b)
        {
            int cpt = 0;
            foreach (Book book in books)
            {
                if (book.Equals(b))
                    cpt++;
            }
            return cpt;

        }

        public int Count()
        {
            return books.Count;


        }

        public int HowManyDifferent()
        {
            var different = books.Distinct();
            return different.Count();
        }

        public bool IsEmpty()
        {
            if (books.Count == null)
            {
                return true;
            }
            return false;
        }





        public Basket RemoveDifferent(int nbToRemove)
        {
            var distinctDataSorted = books.Distinct().OrderBy(x => HowMany(x));

            var ToRemove = distinctDataSorted.Reverse().Take(nbToRemove);

            foreach (var livre in ToRemove)
            {
                books.ToList().Remove(books.First(boukin => boukin.Equals(livre))); // Remove item
            }
            return new Basket(books.ToList());
        }
    }
}