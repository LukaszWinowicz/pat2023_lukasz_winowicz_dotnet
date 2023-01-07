using AutoMapper;
using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;
using pat2023_lukasz_winowicz_dotnet.Entities.Database;
using pat2023_lukasz_winowicz_dotnet.Interfaces;

namespace pat2023_lukasz_winowicz_dotnet.Services
{

    public class AuthorService : IAuthorService
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IMapper _mapper;

        public AuthorService(DatabaseContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public IEnumerable<AuthorDto> GetAll(string search)
        {
            var authors = _databaseContext.Authors.Where(x => search == null || (x.LastName.ToLower().Contains(search))).ToList();
            var authorsDto = _mapper.Map<List<AuthorDto>>(authors);
            return authorsDto;
        }
        public int Create(AuthorDto dto)
        {
            var author = _mapper.Map<Author>(dto);
            _databaseContext.Authors.Add(author);
            _databaseContext.SaveChanges();
            return author.Id;
        }

        public IEnumerable<BookDto> GetBooksByAuthor(string LastName)
        { 
            var books = _databaseContext.BookAuthors.Where(a => a.Author.LastName == LastName).Select(b => b.Book).ToList();
            var booksDto = _mapper.Map<List<BookDto>>(books);
            return booksDto;
        }
    }
}
