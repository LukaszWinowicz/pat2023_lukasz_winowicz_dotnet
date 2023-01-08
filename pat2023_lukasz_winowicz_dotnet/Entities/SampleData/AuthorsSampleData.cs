namespace pat2023_lukasz_winowicz_dotnet.Entities.SampleData
{
    public static class AuthorsSampleData
    {
        public static IList<Author> sampleAuthors = new List<Author>()
        {
            new Author
            {
                Id = 1,
                FirstName = "Haruki",
                LastName = "Murakami",
                BirthDate = new DateTime(1949, 1, 12),
                Gender = false
            },
            new Author
            {
                Id = 2,
                FirstName = "J.R.R.",
                LastName = "Tolkien",
                BirthDate = new DateTime(1892, 1, 3),
                Gender = false
            },
            new Author
            {
                Id = 3,
                FirstName = "J.K.",
                LastName = "Rowling",
                BirthDate = new DateTime(1965, 7, 31),
                Gender = true
            },
            new Author
            {
                Id = 4,
                FirstName = "Ernest",
                LastName = "Hemingway",
                BirthDate = new DateTime(1889, 7, 21),
                Gender = false
            },
            new Author
            {
                Id = 5,
                FirstName = "Jane",
                LastName = "Austen",
                BirthDate = new DateTime(1775, 12, 16),
                Gender = true
            },
            new Author
            {
                Id = 6,
                FirstName = "Stephen",
                LastName = "King",
                BirthDate = new DateTime(1947, 9, 21),
                Gender = false
            },
            new Author
            {
                Id = 7,
                FirstName = "Elena",
                LastName = "Ferrante",
                BirthDate = new DateTime(1943, 4, 5),
                Gender = true
            },
            new Author
            {
                Id = 8,
                FirstName = "John",
                LastName = "Irving",
                BirthDate = new DateTime(1942, 3, 2),
                Gender = false
            }
        };
    }
}
