using pat2023_lukasz_winowicz_dotnet.Dto;

namespace pat2023_lukasz_winowicz_dotnet.Interfaces
{
    public interface IAuthorService
    {
        IEnumerable<AuthorDto> GetAll(string searchAuthor);
        int Create(CreateAuthorDto dto);
    }
}
