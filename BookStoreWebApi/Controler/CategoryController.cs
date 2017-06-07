using BookStoreWebApi.Models;
using BookStoreWebApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Controler
{
    //[Route("api/[controller]")]
    public class CategoryController:Controller
    {
        private readonly ICategory _categories;

        public CategoryController(ICategory categoryRepository)
        {
            _categories = categoryRepository;
        }

         [Route("api/catego")]
         public IActionResult GetAllCategorys()
         {
             //List<Category> Categories = _categories.GetAllCategory();
             return Content("value");
         }

        [HttpGet("{id}")]
        public IActionResult GetCategory(long id)
        {
            Category Category = _categories.GetCategory(id);
            if (Category == null)
            {
                throw new Exception();
            }
            return null;
        }
    }
}

//[HttpPost]
//public IActionResult CreateCategory([FromBody] Category Category)
//{
//    if (ModelState.IsValid == false)
//    {
//        return BadRequest(ModelState);
//    }

//    Category createdCategory = _categories.CreateCategory(Category);

//    return CreatedAtAction(
//        nameof(GetCategory), new { id = createdCategory.Id }, createdCategory);
//}


//[HttpPut("{id}")]
// public IActionResult UpdateCategory(long id, [FromBody] Category Category)
// {
//     if (ModelState.IsValid == false)
//     {
//         return BadRequest(ModelState);
//     }

//     try
//     {
//         _categories.UpdateCategory(id, Category);
//         return Ok();
//     }
//     catch (Exception Ex)
//     {

//     }
// }

 //[HttpDelete("{id}")]
 //public IActionResult DeleteCategory(long id)
 //{
 //    _categories.DeleteCategory(id);
 //    return Ok();
 //}


