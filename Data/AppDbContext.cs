using System;
using System.Collections.Generic;
using System.Linq;
using System. Threading.Tasks;
using eBookStall.Models;
using Microsoft.EntityFrameworkCore;

namespace eBookStall.Data
{
    public class AppDbContext :DbContext
    {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
      {
      }
         public DbSet<Book> Books  {get; set;}
    }
}