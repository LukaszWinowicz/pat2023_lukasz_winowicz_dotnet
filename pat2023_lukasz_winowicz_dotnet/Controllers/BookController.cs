using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;
using pat2023_lukasz_winowicz_dotnet.Entities.Database;
using System.Net;

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
        {
            var book = _mapper.Map<Book>(dto);
            _databaseContext.Books.Add(book);
            _databaseContext.SaveChanges();
            return Created($"/api/books/{book.Id}", null);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        { 
            var book = _databaseContext.Books.FirstOrDefault(x => x.Id == id);
            _databaseContext.Books.Remove(book);
            _databaseContext.SaveChanges();
            return NotFound();

        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] UpdateBookDto dto, [FromRoute] int id)
        {
        var book = _databaseContext.Books.FirstOrDefault(x =>x.Id == id);

            book.Title = dto.Title;
            book.Description = dto.Description;
            book.Rating = dto.Rating;
            book.ISBN = dto.ISBN;
            book.PublicationDate = dto.PublicationDate;
            _databaseContext.SaveChanges();
            return Ok();
        }
    }
}
