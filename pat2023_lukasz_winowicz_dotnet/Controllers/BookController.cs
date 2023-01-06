using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;
using pat2023_lukasz_winowicz_dotnet.Entities.Database;
using pat2023_lukasz_winowicz_dotnet.Services;
using System.Net;

namespace pat2023_lukasz_winowicz_dotnet.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        #region HttpGet
            [HttpGet] // /api/books
            public ActionResult<IEnumerable<BookDto>> GetAll()
            {
                var booksDto = _bookService.GetAll();
                if (booksDto.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(booksDto);
            }
        #endregion

        #region HttpPost
            [HttpPost] // /api/books/ + body in JSON
            public ActionResult Create([FromBody] CreateBookDto dto)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var id = _bookService.Create(dto);

                return Created($"/api/books/{id}", null);
            }
        #endregion

        #region HttpDelete
            [HttpDelete("{id}")] // /api/books/{id}
            public ActionResult Delete([FromRoute] int id)
            {
                var isDeleted = _bookService.Delete(id);
                if (isDeleted)
                {
                    return NoContent();
                }

                return NotFound();
            }
        #endregion

        #region HttpPut
            [HttpPut("{id}")] // /api/books/{id} + body in JSON
            public ActionResult Update([FromBody] UpdateBookDto dto, [FromRoute] int id)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var isUpdated = _bookService.Update(id, dto);

                if (!isUpdated)
                {
                    return NotFound();
                }

                return Ok();
            }
        #endregion
    }
}