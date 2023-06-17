using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace eBookStall.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Bookname")]
        [Required(ErrorMessage ="BookName is required")]
        public String? BookName { get; set; }

        [Display(Name = "Authorname")]
        [Required(ErrorMessage ="AuthorName is required")]
        public string? AuthorName { get; set; }
        
        [Display(Name = "Publishername")]
        [Required(ErrorMessage ="PublisherName is required")]
        public string? PublisherName { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage ="Price is required")]
        public double Price { get; set; }
        [Display(Name = "ImageURL")]
        [Required(ErrorMessage ="ImageURL is required")]
        public string? ImageURL { get; set; }
        

    }
}