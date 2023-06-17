using eBookStall.Data;
using eBookStall.Data.Services;
using eBookStall.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eBookStall.Controllers
{
    public class AddbooksController : Controller
    {
        private readonly IBooksService _booksService;
        public AddbooksController(IBooksService booksService)
        {
            _booksService= booksService;
        }
        public IActionResult Index()
        {
            
           return View();
        }
        [HttpPost]
        public IActionResult Index(Book book)
        {
            Book newbook= _booksService.Add(book);
            return RedirectToAction("Books");
        }
        [HttpGet]
        public IActionResult Books()
        {
            var books=_booksService.GetAllBook();
            return View(books);
        }
        
            
          
    }
  
}