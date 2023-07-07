using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phil_Library
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> borrowedBooks;


        public Backpack()
        {
            borrowedBooks = new List<T>();
        }
        public void Pack(T books)
        {

            borrowedBooks.Add(books);


        }

        public T Unpack(int index)
        {
            var book = borrowedBooks[index];
            borrowedBooks.RemoveAt(index);
            return book;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var book in borrowedBooks)
            {
               yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var book in borrowedBooks)
            {
                yield return book;
            }
        }
    }
}
