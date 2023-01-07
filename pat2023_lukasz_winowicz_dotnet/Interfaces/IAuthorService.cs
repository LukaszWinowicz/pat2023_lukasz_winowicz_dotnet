using pat2023_lukasz_winowicz_dotnet.Dto;

namespace pat2023_lukasz_winowicz_dotnet.Interfaces
{
    public interface IAuthorService
    {
        IEnumerable<AuthorDto> GetAll(string search);
        int Create(CreateAuthorDto dto);
    }
}
