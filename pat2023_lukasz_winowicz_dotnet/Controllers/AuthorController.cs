using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;
using pat2023_lukasz_winowicz_dotnet.Entities.Database;

namespace pat2023_lukasz_winowicz_dotnet.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IMapper _mapper;

        public AuthorController(DatabaseContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AuthorDto>> GetAll()
        {
            var authors = _databaseContext.Authors.ToList();
            var authorsDto = _mapper.Map<List<AuthorDto>>(authors);
            return authorsDto;
        }
    }
}
