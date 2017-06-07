using BookStoreWebApi.DAL;
using BookStoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Repository
{
    public class BookReviewsRepository :IBooksReviews
    {

        private readonly StoreDataContext _db;

        public BookReviewsRepository(StoreDataContext db)
        {
            _db = db;
        }

        public BookReviews CreateBookReviews(BookReviews BookReviews)
        {
            _db.BookReview.Add(BookReviews);
            _db.SaveChanges();
            return BookReviews;
        }

        public BookReviews CreateBooksReviews(BookReviews BooksReviews)
        {
            throw new NotImplementedException();
        }

        public void DeleteBookReviews(long id)
        {
            BookReviews BookReviews = GetBookReviews(id);
            if (BookReviews != null)
            {
                //_db.BooksReviews.Remove(BookReviews);
                _db.SaveChanges();
            }
        }

        public void DeleteBooksReviews(long id)
        {
            throw new NotImplementedException();
        }

        public List<BookReviews> GetAllBookReviewss()
        {
            //return _db.BookReviewss.AsNoTracking().ToList();
            return null; 
        }

        public List<BookReviews> GetAllBooksReviewss()
        {
            throw new NotImplementedException();
        }

        public BookReviews GetBookReviews(long id)
        {
            //return _db.BookReviewss.FirstOrDefault(p => p.Id == id);
            return null;
        }

        public BookReviews GetBooksReviews(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBookReviews(long id, BookReviews updatedBookReviews)
        {
            BookReviews BookReviews = GetBookReviews(id);

            if (BookReviews == null)
            {
                throw new Exception();
            }

            
            _db.SaveChanges();
        }

        public void UpdateBooksReviews(long id, BookReviews BooksReviews)
        {
            throw new NotImplementedException();
        }
    }
}
    

