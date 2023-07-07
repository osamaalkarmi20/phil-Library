
using System;
using System.Collections.Generic;

namespace phil_Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.Add("pirats", "nour", "mohammad", 100);
            library.Add("poor dad", "adele", "kaled", 200);
            library.Add("reach the stars", "ahmad", "riad", 300);
            Console.WriteLine("this is all the books are in the library:");
            Console.WriteLine(" ");
            foreach (var item in library)
            {
                Console.WriteLine($"{item.Title}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("lets for example borrow the first book which is pirats and pack it this the library know :");
            Console.WriteLine(" ");
            Backpack<Book> backpack = new Backpack<Book>();
            var book = library.Borrow("pirats");
            
            backpack.Pack(book);
           
            foreach (var item in library)
            {
                Console.WriteLine($"{item.Title}");
            }
            Console.WriteLine(" ");
            Console.WriteLine($"lets unpack it  and return it :");
            Console.WriteLine(" ");
            backpack.Unpack(0);
            library.Return(book);
            foreach (var item in library)
            {
                Console.WriteLine($"{item.Title}");
            }
           
        }
    }

  

}
