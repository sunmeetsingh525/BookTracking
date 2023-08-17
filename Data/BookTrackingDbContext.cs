using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class BookTrackingDbContext : DbContext
    {
        public BookTrackingDbContext (DbContextOptions<BookTrackingDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<CategoryType> CategoryType { get; set; }
    }
