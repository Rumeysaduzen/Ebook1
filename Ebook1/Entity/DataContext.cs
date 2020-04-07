using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Ebook1.Entity
{
    public class DataContext:DbContext
    {
        public DataContext(): base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
     
        public DbSet<Department> Departments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}