using AutoMapper;
using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;

namespace pat2023_lukasz_winowicz_dotnet.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Author, AuthorDto>().ReverseMap();

            CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}
