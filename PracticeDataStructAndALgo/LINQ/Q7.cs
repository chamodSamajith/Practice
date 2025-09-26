namespace PracticeDataStructAndALgo.LINQ
{
    public class Q7
    {
        public class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }


        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int CopiesSold { get; set; }
        }

        public static void Run()
        {
            var libraries = new List<Library>
            {
                new Library
                {
                    Name = "Central Library",
                    Books = new List<Book>
                    {
                        new Book { Title = "C# Basics", Author = "Alice", CopiesSold = 500 },
                        new Book { Title = "LINQ Mastery", Author = "Bob", CopiesSold = 300 }
                    }
                },
                new Library
                {
                    Name = "Community Library",
                    Books = new List<Book>
                    {
                        new Book { Title = "Advanced C#", Author = "Alice", CopiesSold = 700 },
                        new Book { Title = "Databases 101", Author = "Charlie", CopiesSold = 200 }
                    }
                },
                new Library
                {
                    Name = "University Library",
                    Books = new List<Book>
                    {
                        new Book { Title = "Algorithms", Author = "Bob", CopiesSold = 400 },
                        new Book { Title = "Machine Learning", Author = "Alice", CopiesSold = 600 }
                    }
                }
            };
            //find the top 2 authors across all libraries who sold the most total copies of all their books combined.
            //Return the author name and the total copies sold.
            //Expected output
            // Alice - 1800
            // Bob - 700

            var topAuthors = libraries
            .SelectMany(o => o.Books, (o, book) => new { author = book.Author, copies = book.CopiesSold })
            .GroupBy(d => d.author).Select(d => new { author = d.Key, copies = d.Sum(d => d.copies) }).OrderByDescending(d => d.copies).Take(2);

            foreach (var i in topAuthors)
                Console.WriteLine($"{i.author} - {i.copies}");

        }

    }
}