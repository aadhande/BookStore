using BookStoreWebApi.DAL;
using BookStoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Repository
{
    public class BooksRepository :IBooks
    {
        private readonly StoreDataContext _db;

        public BooksRepository(StoreDataContext db)
        {
            _db = db;
        }

        public Books CreateBooks(Books Books)
        {
            _db.Book.Add(Books);
            _db.SaveChanges();
            return Books;
        }

        public void DeleteBooks(long id)
        {
            Books Books = GetBooks(id);
            if (Books != null)
            {
                _db.Book.Remove(Books);
                _db.SaveChanges();
            }
        }

        public List<Books> GetAllBookss()
        {
            // return _db.Book.AsNoTracking().ToList();
            return null;
        }

        public Books GetBooks(long id)
        {
            // return _db.Book.FirstOrDefault(p => p.Id == id);
            return null;
        }

        public void UpdateBooks(long id, Books updatedBooks)
        {
            Books Books = GetBooks(id);

            if (Books == null)
            {
                throw new Exception();
            }

            //Books.Name = updatedBooks.Name;
            //Books.Category = updatedBooks.Category;
            //Books.Price = updatedBooks.Price;

            _db.SaveChanges();
        }
    }
}
    
