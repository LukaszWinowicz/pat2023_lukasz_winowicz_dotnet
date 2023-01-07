using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;
using pat2023_lukasz_winowicz_dotnet.Entities.Database;
using pat2023_lukasz_winowicz_dotnet.Interfaces;

namespace pat2023_lukasz_winowicz_dotnet.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        #region HttpGet - GetAll
        [HttpGet] // /api/authors?search=Tolkien
        public ActionResult<IEnumerable<AuthorDto>> GetAll([FromQuery] string search)
            {
                var authorsDto = _authorService.GetAll(search);

                if (authorsDto.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(authorsDto);
            }
        #endregion

        #region HttpPost
            [HttpPost] // /api/authors/ + body in JSON
            public ActionResult Create([FromBody] AuthorDto dto)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var id = _authorService.Create(dto);

                return Created($"/api/authors/{id}", null);
            }
        #endregion

        #region HttpGet - GetBooksByAuthor
            [HttpGet("{searchBooks}")] // /api/authors/searchBooks?LastName=Tolkien
            public ActionResult<IEnumerable<BookDto>> GetBooksByAuthor([FromQuery] string LastName)
            {
                var booksDto = _authorService.GetBooksByAuthor(LastName);

                if (booksDto.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(booksDto);
            }
        #endregion
    }
}