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

        }

    }
}