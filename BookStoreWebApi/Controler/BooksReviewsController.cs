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
    public class BooksReviewsController:Controller
    {
        private IBooksReviews _BooksReviews;

        public void BooksReviewssController(IBooksReviews BooksReviewsRepository)
        {
            _BooksReviews = BooksReviewsRepository;
        }

        [HttpGet("")]
        public IActionResult GetAllBooksReviewss()
        {
            List<BookReviews> BooksReviewss = _BooksReviews.GetAllBooksReviewss();
            return null;
        }
    }

    //[HttpGet("{id}")]
    //public IActionResult GetBooksReviews(long id)
    //{
    //    BooksReviews BooksReviews1 = _BooksReviews.GetBooksReviews(id);
    //    if (BooksReviews == null)
    //    {
    //        return null;
    //    }
    //    return null;
    //}

    //[HttpPost]
    //public IActionResult CreateBooksReviews([FromBody] BooksReviews BooksReviews)
    //{
    //    if (ModelState.IsValid == false)
    //    {
    //        return BadRequest(ModelState);
    //    }

    //    BooksReviews createdBooksReviews = _BooksReviewss.CreateBooksReviews(BooksReviews);

    //    return CreatedAtAction(
    //        nameof(GetBooksReviews), new { id = createdBooksReviews.Id }, createdBooksReviews);
    //}

    //[HttpPut("{id}")]
    //public IActionResult UpdateBooksReviews(long id, [FromBody] BooksReviews BooksReviews)
    //{
    //    if (ModelState.IsValid == false)
    //    {
    //        return new EmptyResult();
    //    }

    //    try
    //    {
    //        _BooksReviewss.UpdateBooksReviews(id, BooksReviews);
    //        return null;

    //    }
    //    catch (Exception Ex)
    //    {

    //    }
}


    //    [HttpDelete("{id}")]
    //    public IActionResult DeleteBooksReviews(long id)
    //    {
    //        _BooksReviewss.DeleteBooksReviews(id);
    //        return  null;
    //    }
    //}

