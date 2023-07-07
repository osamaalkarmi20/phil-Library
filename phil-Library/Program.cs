
using System;
using System.Collections.Generic;

namespace phil_Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.Add("1", "FIRST", "LAST", 100);
            library.Add("2", "FIRST", "LAST", 200);
            library.Add("3", "FIRST", "LAST", 300);
            foreach (var item in library)
            {
                Console.WriteLine($"{item.Title}");
            }
            Backpack<Book> backpack = new Backpack<Book>();
            var book = library.Borrow("1");
          
            Console.WriteLine($"the book that is packed ");
            backpack.Pack(book);
            Console.WriteLine($"the book that is borrowed ");
            Console.WriteLine($"{book.Pages}");
            Console.WriteLine($"after borrowing"); 
            foreach (var item in library)
            {
                Console.WriteLine($"{item.Title}");
            }
            Console.WriteLine($"the book that is unpacked ");
            Console.WriteLine($"{backpack.Unpack(0).Title}");
            Console.WriteLine($"RETURN");
            library.Return(book);

            foreach (var item in library)
            {
                Console.WriteLine($"{item.Title}");
            }
           
        }
    }

  

}
