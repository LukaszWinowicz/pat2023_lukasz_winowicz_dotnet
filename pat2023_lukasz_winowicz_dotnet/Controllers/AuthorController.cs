﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pat2023_lukasz_winowicz_dotnet.Dto;
using pat2023_lukasz_winowicz_dotnet.Entities;
using pat2023_lukasz_winowicz_dotnet.Entities.Database;
using pat2023_lukasz_winowicz_dotnet.Services;

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

        #region HttpGet
            [HttpGet] // /api/authors
            public ActionResult<IEnumerable<AuthorDto>> GetAll()
            {
                var authorsDto = _authorService.GetAll();

                if (authorsDto.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(authorsDto);
            }
        #endregion

        #region HttpPost
            [HttpPost] // /api/authors/ + body in JSON
            public ActionResult Create([FromBody] CreateAuthorDto dto)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var id = _authorService.Create(dto);

                return Created($"/api/authors/{id}", null);
            }
        #endregion
    }
}