using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;

namespace pat2023_lukasz_winowicz_dotnet.Interfaces
{
    public interface IAuthorService
    {
        IEnumerable<AuthorDto> GetAll(string search);
        int Create(AuthorDto dto);
        IEnumerable<BookDto> GetBooksByAuthor(string LastName);
    }
}
