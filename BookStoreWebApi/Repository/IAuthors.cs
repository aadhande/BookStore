using BookStoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Repository
{
    public interface IAuthors
    {
        
        //List<Authors> GetAllAuthorss();
        Authors GetAuthors(long id);
      //  Authors CreateAuthors(Authors Authors);
       // void UpdateAuthors(long id, Authors Authors);
       // void DeleteAuthors(long id);
        //List<Authors> GetAllAuthors();
    }
}


