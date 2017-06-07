using BookStoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Repository
{
    public interface ICategory
    {
          List<Category> GetAllCategories();
           Category GetCategory(long id);
            Category CreateCategory(Category Category);
           void UpdateCategory(long id, Category updatedCategory);
          ///void DeleteCategory(long id);
            
        }
    }

