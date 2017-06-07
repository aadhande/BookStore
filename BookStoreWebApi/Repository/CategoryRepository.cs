using BookStoreWebApi.DAL;
using BookStoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Repository
{
    public class CategoryRepository:ICategory
    {
        private readonly StoreDataContext _db;

        public CategoryRepository(StoreDataContext db)
        {
            _db = db;
        }
        
        public Category CreateCategory(Category Category)
        {
       //     Category.CreatedAt = DateTimeOffset.Now;

            _db.Categorys.Add(Category);
            _db.SaveChanges();
            return Category;
        }

       //public void DeleteCategory(long id)
       // {
       //     throw new NotImplementedException();
       // }

        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

      public Category GetCategory(long id)
       {
         throw new NotImplementedException();
       }

        public void UpdateCategory(long id, Category updatedCategory)
        {
            throw new NotImplementedException();
        }

        // public void DeleteCategory(long id)
        //{
        //  Category Category = GetCategory(id);
        //if (Category != null)
        //{
        //   _db.Categorys.Remove(Category);
        // _db.SaveChanges();
        //}
        //}


        //  public List<Category> GetAllCategorys()
        //{
        // return _db.Category.AsNoTracking().ToList();
        //}

        //public Category GetCategory(long id)
        //{
        //  return _db.Categorys.FirstOrDefault(o => o.Id == id);
        //}





    }
}
