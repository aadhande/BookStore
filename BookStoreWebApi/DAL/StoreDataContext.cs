using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreWebApi.Models;

namespace BookStoreWebApi.DAL
{
    public class StoreDataContext: DbContext
    {
        public StoreDataContext(DbContextOptions<StoreDataContext> options)
        : base(options)
        {
        }


        public DbSet<Authors> Author { get; set; }
        public DbSet<Books> Book { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<BookReviews> BookReview{ get; set; }
    }
}
