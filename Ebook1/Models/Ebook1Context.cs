namespace Ebook1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Ebook1Context : DbContext
    {
        public Ebook1Context()
            : base("name=Ebook1Context1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAndRole> UserAndRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAndRole>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<UserAndRole>()
                .Property(e => e.role_name)
                .IsFixedLength();
        }
    }
}
