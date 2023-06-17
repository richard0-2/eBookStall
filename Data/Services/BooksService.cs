using eBookStall.Models;

namespace eBookStall.Data.Services
{
    public class BooksService : IBooksService
    {  
        private readonly AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context=context;
        }

        public Book Add(Book book)
        {
           _context.Books.Add(book);
           _context.SaveChanges();
           return book;
        }

        public Book Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllBook()
        {
            return _context.Books;
        }

        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public Book Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}


