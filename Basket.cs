
using System.Collections.Generic;
using System.Linq;


namespace HarryPotter
{
    public class Basket
    {
        private readonly IList<Book> _books;
        public Basket(IEnumerable<Book> books)
        {
            _books = (IList<Book>) books.ToList();
        }

        public int HowMany(Book b)
        {
            return  _books.Count(x => x == b);

        }

        public int Count()
        {
            var x = _books.Count;
            return x;

        }

        public int HowManyDifferent()
        {
            return _books.Distinct().Count();
        }

        public  bool IsEmpty()
        {
            return !(_books != null && _books.Any());
            


        }

        public Basket RemoveDifferent(int nbToRemove)
        {
            var distinctData =  this._books.Distinct();
            var sortedData = distinctData.OrderBy(x => HowMany(x));
            var booksToRemove = sortedData.Reverse().Take(nbToRemove);
            var booksData = _books.ToList(); // Get IEnumerable as List

            foreach (var item in booksToRemove)
            {


                booksData.Remove(_books.First(x => x.Equals(item))); // Remove item
            }
            return new Basket(booksData);
        }
    }
}