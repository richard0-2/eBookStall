using eBookStall.Data;
using eBookStall.Data.Services;
using eBookStall.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eBookStall.Controllers
{
    public class BookController : Controller
    {
        private readonly IBooksService _booksService;
        public BookController(IBooksService booksService)
        {
            _booksService= booksService;
        }
        
        public IActionResult Index()
        {
           var books=_booksService.GetAllBook();
            return View(books);
        }
    }
          
}
  

