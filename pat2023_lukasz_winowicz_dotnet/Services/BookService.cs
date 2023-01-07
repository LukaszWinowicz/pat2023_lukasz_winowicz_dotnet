using AutoMapper;
using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;
using pat2023_lukasz_winowicz_dotnet.Entities.Database;
using pat2023_lukasz_winowicz_dotnet.Interfaces;

namespace pat2023_lukasz_winowicz_dotnet.Services
{

    public class BookService : IBookService
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IMapper _mapper;

        public BookService(DatabaseContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public IEnumerable<BookDto> GetAll()
        {
            var books = _databaseContext.Books.ToList();
            var booksDto = _mapper.Map<List<BookDto>>(books);
            return booksDto;
        }

        public int Create(BookDto dto)
        {
            var book = _mapper.Map<Book>(dto);
            _databaseContext.Books.Add(book);
            _databaseContext.SaveChanges();
            return book.Id;
        }

        public bool Delete(int id)
        {
            var book = _databaseContext
                .Books
                .FirstOrDefault(b => b.Id == id);

            if (book is null) return false;

            _databaseContext.Books.Remove(book);
            _databaseContext.SaveChanges();
            return true;
        }

        public bool Update(int id, BookDto dto)
        {
            var book = _databaseContext
                .Books
                .FirstOrDefault(b => b.Id == id);

            if (book is null)
                return false;

            book.Title = dto.Title;
            book.Description = dto.Description;
            book.Rating = dto.Rating;
            book.ISBN = dto.ISBN;
            book.PublicationDate = dto.PublicationDate;

            _databaseContext.SaveChanges();
            return true;
        }
    }
}
