using BookStoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Repository
{
    public interface IBooks
    {
        
        List<Books> GetAllBookss();
        Books GetBooks(long id);
        Books CreateBooks(Books Books);
        void UpdateBooks(long id, Books Books);
        void DeleteBooks(long id);
    }
}

