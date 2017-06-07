using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string publishdate { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string imageUrl { get; set; }

        
    }
}
