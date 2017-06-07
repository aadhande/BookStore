using BookStoreWebApi.DAL;
using BookStoreWebApi.Models;
using BookStoreWebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AuthorstoreWebApi.Repository
{
    public class AuthorsRepository : IAuthors
    {

        private readonly StoreDataContext _db;

        public AuthorsRepository(StoreDataContext db)
        {
            _db = db;
        }

        //public Authors CreateAuthors(Authors Authors)
        //{
        //    _db.Book.Add(Authors);
        //    _db.SaveChanges();
        //    return Authors;
        //}

        //public void DeleteAuthors(long id)
        //{
        //    IAuthors Authors = GetAuthors(id);
        //    if (Authors != null)
        //    {
        //        _db.Book.Remove(Authors);
        //        _db.SaveChanges();
        //    }
        //}

        //public List<Authors> GetAllAuthorss()
        //{
        //    return _db.Book.AsNoTracking().ToList();
        //}

        public Authors GetAuthors(long id)
        {
            // return _db.Book.FirstOrDefault(p => p.Id == id);
            return null;
        }

    }
}

//        public void UpdateAuthors(long id, Authors updatedAuthors)
//        {
//            Authors Authors = GetAuthors(id);

//            if (Authors == null)
//            {
//                throw new EntityNotFoundException<Authors>(id);
//            }

//            Authors.Name = updatedAuthors.Name;
//            Authors.Category = updatedAuthors.Category;
//            Authors.Price = updatedAuthors.Price;

//            _db.SaveChanges();
//        }
//    }
//}
    


    
