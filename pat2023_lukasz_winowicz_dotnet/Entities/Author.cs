namespace pat2023_lukasz_winowicz_dotnet.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
