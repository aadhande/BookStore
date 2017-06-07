using BookStoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Repository
{
public interface IBooksReviews
    {
        
        List<BookReviews> GetAllBooksReviewss();
        BookReviews GetBooksReviews(long id);
        BookReviews CreateBooksReviews(BookReviews BooksReviews);
        void UpdateBooksReviews(long id, BookReviews BooksReviews);
        void DeleteBooksReviews(long id);
    }
}

