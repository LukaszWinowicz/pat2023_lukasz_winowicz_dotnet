﻿namespace pat2023_lukasz_winowicz_dotnet.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
