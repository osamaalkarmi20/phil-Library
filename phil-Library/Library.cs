using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace phil_Library
{
    public class Library : ILibrary
    {
        private Dictionary<string, Book> dictionary;
        public Library()
        {
            dictionary = new Dictionary<string, Book>();
        }
        public int Count => dictionary.Count();

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            var book = new Book { Title = title, Author = firstName + lastName, Pages = numberOfPages };
            dictionary.Add(title, book);


        }

        public Book Borrow(string title)
        {
            if (dictionary.ContainsKey(title))
            {
                Book borrow = dictionary[title];
                dictionary.Remove(title);
                return borrow;
            }
            return null;
        }

        public void Return(Book book)
        {
            dictionary.Add(book.Title, book);

        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in dictionary.Values)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var book in dictionary.Values)
            {
                yield return book;
            }
        }
    }
}
