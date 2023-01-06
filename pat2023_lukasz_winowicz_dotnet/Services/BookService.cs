using AutoMapper;
using Microsoft.EntityFrameworkCore;
using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;
using pat2023_lukasz_winowicz_dotnet.Entities.Database;

namespace pat2023_lukasz_winowicz_dotnet.Services
{
    public interface IBookService
    {
        IEnumerable<BookDto> GetAll();
        int Create(CreateBookDto dto);
        bool Delete(int id);
        bool Update(int id, UpdateBookDto dto);
    }



    public class BookService : IBookService
    {
        private readonly DatabaseContext _bookShopDbContext;
        private readonly IMapper _mapper;

        public BookService(DatabaseContext bookShopDbContext, IMapper mapper)
        {
            _bookShopDbContext = bookShopDbContext;
            _mapper = mapper;
        }

        public IEnumerable<BookDto> GetAll()
        {
            var books = _bookShopDbContext.Books.ToList();
            var booksDto = _mapper.Map<List<BookDto>>(books);
            return booksDto;
        }

        public int Create(CreateBookDto dto)
        {
            var book = _mapper.Map<Book>(dto);
            _bookShopDbContext.Books.Add(book);
            _bookShopDbContext.SaveChanges();
            return book.Id;
        }

        public bool Delete(int id)
        {
            var book = _bookShopDbContext
                .Books
                .FirstOrDefault(b => b.Id == id);

            if (book is null) return false;

            _bookShopDbContext.Books.Remove(book);
            _bookShopDbContext.SaveChanges();
            return true;
        }

        public bool Update(int id, UpdateBookDto dto)
        {
            var book = _bookShopDbContext
                .Books
                .FirstOrDefault(b => b.Id == id);

            if (book is null)
                return false;

            book.Title = dto.Title;
            book.Description = dto.Description;
            book.Rating = dto.Rating;
            book.ISBN = dto.ISBN;
            book.PublicationDate = dto.PublicationDate;

            _bookShopDbContext.SaveChanges();
            return true;
        }
    }
}
