using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Models
{
    public class BookReviews
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string Reviewer_Name { get; set; }
        [Required]
        public string Review_Text { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public DateTime publish_date { get; set; }
    }
}
