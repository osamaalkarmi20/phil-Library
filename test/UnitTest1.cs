using phil_Library;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void add()
        {
            Library l1 = new Library();
            l1.Add("1", "FIRST", "LAST", 100);
            int res = l1.Count;
            Assert.Equal(1, res);
        }
        [Fact]
        public void borrowBook1()
        {
            Library l1 = new Library();
            l1.Add("1", "FIRST", "LAST", 100);
            l1.Add("2", "FIRST", "LAST", 200);
            l1.Borrow("2");
            int res = l1.Count;
            Assert.Equal(1, res);
        }
        [Fact]
        public void borrowBook2()
        {
            Library l1 = new Library();
            l1.Add("1", "FIRST", "LAST", 100);
            l1.Add("2", "FIRST", "LAST", 200);

            Book book = l1.Borrow("2");
            Assert.DoesNotContain(book, l1);

        }
        [Fact]
        public void borrowBookNull()
        {
            Library l1 = new Library();
            l1.Add("1", "FIRST", "LAST", 100);
            l1.Add("2", "FIRST", "LAST", 200);

            Book book = l1.Borrow("4");
            Assert.Equal(book, null);

        }
        [Fact]
        public void Return1()
        {
            Library l1 = new Library();
            l1.Add("1", "FIRST", "LAST", 100);
            l1.Add("2", "FIRST", "LAST", 200);
            Book book = l1.Borrow("2");
            l1.Return(book);

            Assert.Contains(book, l1);
        }
        [Fact]
        public void Return2()
        {
            Library l1 = new Library();
            l1.Add("1", "FIRST", "LAST", 100);
            l1.Add("2", "FIRST", "LAST", 200);
            Book book = l1.Borrow("2");
            l1.Return(book);
            int res = l1.Count;
            Assert.Equal(2, res);
        }
        [Fact]
        public void pack()
        {
            Backpack<Book> backpack = new Backpack<Book>();

            var b1 = new Book { Author = "ss", Title = "oooo", Pages = 12 };
            backpack.Pack(b1);
            var b2 = new Book { Author = "aa", Title = "fgfg", Pages = 342 };
            backpack.Pack(b2);
            int countInc = backpack.Count();
            Assert.Equal(2, countInc);
        }
        [Fact]
        public void unpack()
        {
            Backpack<Book> backpack = new Backpack<Book>();

            var b1 = new Book { Author = "ss", Title = "oooo", Pages = 12 };
            var b2 = new Book { Author = "aa", Title = "fgfg", Pages = 342 };
            backpack.Pack(b1);
            
            backpack.Pack(b2);
            
            backpack.Unpack(1);
            int countDec= backpack.Count();

            Assert.Equal(1, countDec);
        }
    }
}