using System;
using System.Collections.Generic;
using System.Linq;
using System. Threading.Tasks;
using eBookStall.Models;

namespace eBookStall.Data.Services
{
    public interface IBooksService
    {
        Book Add(Book book);
        Book  Update(Book book);
        Book Delete(int id);
        Book GetBook(int id);
        IEnumerable<Book> GetAllBook();
    }
}