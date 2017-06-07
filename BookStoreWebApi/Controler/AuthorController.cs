using AuthorstoreWebApi.Repository;
using BookStoreWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BookStoreWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreWebApi.Controler
{
    [Route("api/[controller]")]
    public class AuthorController : Controller
    {
        private readonly IAuthors _Authors;

        public AuthorController(AuthorsRepository AuthorRepository)
        {
            _Authors = AuthorRepository;
        }

        //[HttpGet("")]
        //public IActionResult GetAllAuthors()
        //{
        //    List<Authors> Authors = _Authors.GetAllAuthors();
        //    return Ok(Authors);
        //}

        [HttpGet("{id}")]
        public IActionResult GetAuthor(long id)
        {
            Authors Author = _Authors.GetAuthors(id);
            if (Author == null)
            {
                throw new Exception();
            }
            return null;
        }

        //[HttpPost]
        //public IActionResult CreateAuthor([FromBody] Authors Author)
        //{
        //    if (ModelState.IsValid == false)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    Author createdAuthor = _Authors.CreateAuthor(Author);

        //    return CreatedAtAction(
        //        nameof(GetAuthor), new { id = createdAuthor.Id }, createdAuthor);
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateAuthor(long id, [FromBody] Authors Author)
        //{
        //    if (ModelState.IsValid == false)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    try
        //    {
        //        _Authors.UpdateAuthor(id, Author);
        //        return Ok();
        //    }
        //    catch (Exception Ex)
        //    {

        //    }
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteAuthor(long id)
        //{
        //    _Authors.DeleteAuthor(id);
        //    return Ok();
        //}

    }
}
