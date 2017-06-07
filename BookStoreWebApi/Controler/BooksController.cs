using BookStoreWebApi.Models;
using BookStoreWebApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BookStoreWebApi.Controler
{


    [Route("api/[controller]")]
    public class BooksController: Controller
    {
        private readonly IBooks _Bookss;

        public BooksController(IBooks BooksRepository)
        {
            _Bookss = BooksRepository;
        }

        [HttpGet("")]
        public IActionResult GetAllBookss()
        {
            List<Books> Bookss = _Bookss.GetAllBookss();
            return null;
        }

        [HttpGet("{id}")]
        public IActionResult GetBooks(long id)
        {
            Books Books = _Bookss.GetBooks(id);
            if (Books == null)
            {
                throw new Exception();
            }
            return null;
        }

        //[HttpPost]
        //public IActionResult CreateBooks([FromBody] Books Books)
        //{
        //    if (ModelState.IsValid == false)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    Books createdBooks = _Bookss.CreateBooks(Books);

        //    return CreatedAtAction(
        //        nameof(GetBooks), new { id = createdBooks.Id }, createdBooks);
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateBooks(long id, [FromBody] Books Books)
        //{
        //    if (ModelState.IsValid == false)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    try
        //    {
        //        _Bookss.UpdateBooks(id, Books);
        //        return Ok();
        //    }
        //    catch (Exception Ex)
        //    {

        //    }
        //}

        [HttpDelete("{id}")]
        public IActionResult DeleteBooks(long id)
        {
            _Bookss.DeleteBooks(id);
            return Ok();
        }
    }
}

