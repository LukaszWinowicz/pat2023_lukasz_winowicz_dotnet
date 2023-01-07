using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;

namespace pat2023_lukasz_winowicz_dotnet.Interfaces
{
    public interface IBookService
    {
        IEnumerable<BookDto> GetAll();
        int Create(BookDto dto);
        bool Delete(int id);
        bool Update(int id, BookDto dto);
    }
}
