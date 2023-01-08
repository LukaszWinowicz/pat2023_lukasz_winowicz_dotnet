using Microsoft.EntityFrameworkCore;

namespace pat2023_lukasz_winowicz_dotnet.Entities.SampleData
{
    public class BookAuthorsSampleData
    {
        public static IList<BookAuthor> sampleBookAuthors = new List<BookAuthor>()
        {
           
                new BookAuthor
                {
                    AuthorId = 1,
                    BookId = 1
                },
                new BookAuthor
                {
                    AuthorId = 1,
                    BookId = 2
                },
                new BookAuthor
                {
                    AuthorId = 2,
                    BookId = 3
                },
                new BookAuthor
                {
                    AuthorId = 1,
                    BookId = 4
                },
                new BookAuthor
                {
                    AuthorId = 2,
                    BookId = 5
                },
                new BookAuthor
                {
                    AuthorId = 3,
                    BookId = 6
                },
                new BookAuthor
                {
                    AuthorId = 3,
                    BookId = 7
                },
                new BookAuthor
                {
                    AuthorId = 4,
                    BookId = 8
                },
                new BookAuthor
                {
                    AuthorId = 4,
                    BookId = 9
                },
                new BookAuthor
                {
                    AuthorId = 5,
                    BookId = 10
                },
                new BookAuthor
                {
                    AuthorId = 6,
                    BookId = 11
                },
                new BookAuthor
                {
                    AuthorId = 6,
                    BookId = 12
                },
                new BookAuthor
                {
                    AuthorId = 7,
                    BookId = 13
                },
                new BookAuthor
                {
                    AuthorId = 8,
                    BookId = 14
                },
                new BookAuthor
                {
                    AuthorId = 8,
                    BookId = 15
                }
    };
    }
}
