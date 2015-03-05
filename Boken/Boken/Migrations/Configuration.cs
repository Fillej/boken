namespace Boken.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Boken.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Boken.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Boken.Models.DataContext context)
        {
            context.Authors.AddOrUpdate(x => x.Id,
            new Author() { Id = 1, Name = "blahah" },
            new Author() { Id = 2, Name = "fjdjdfj" },
            new Author() { Id = 3, Name = "fjdifjdifdfj" }
            );
            context.Books.AddOrUpdate(x => x.Id,
            new Book() { Id = 1, Title = "dfdifdifj", Year = DateTime.Now },
            new Book() { Id = 2, Title = "difdifdifj", Year = DateTime.Now },
            new Book() { Id = 3, Title = "jdifdifjd", Year = DateTime.Now }
            );
            context.BookCouplings.AddOrUpdate(x => x.Id,
            new BookCoupling() { Id = 1, BookId = 1, AuthorId = 1 },
            new BookCoupling() { Id = 2, BookId = 1, AuthorId = 3 },
            new BookCoupling() { Id = 3, BookId = 2, AuthorId = 2 },
            new BookCoupling() { Id = 4, BookId = 3, AuthorId = 2 }
            );
        }
    }
}
