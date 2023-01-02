using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;
using pat2023_lukasz_winowicz_dotnet.Entities.Database;

namespace pat2023_lukasz_winowicz_dotnet.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IMapper _mapper;

        public BookController(DatabaseContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BookDto>> GetAll()
        {
            var books = _databaseContext.Books.ToList();
            var booksDto = _mapper.Map<List<BookDto>>(books);
            return booksDto;
        }

        [HttpPost]
        public ActionResult Create([FromBody] CreateBookDto dto)
        { }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        { }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] UpdateBookDto dto, [FromRoute] int id)
        { 
        }
    }
}
