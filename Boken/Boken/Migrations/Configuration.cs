namespace Boken.Migrations
{
    using Boken.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Boken.Models.BookDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Boken.Models.BookDataContext context)
        {
            // set up dummy data to always be present
            // Authors
            context.Authors.AddOrUpdate(
                    new Author() { Id = 1, Name = "Stephen King", Biography = "Stephen King skriver minst en bok i veckan. Han �r fan inte klok." },
                    new Author() { Id = 2, Name = "Dan Brown", Biography = "Daniel 'Dan' Brown, f�dd 22 juni 1964 i Exeter, New Hampshire, �r en amerikansk f�rfattare. Hans mesta k�nd romaner �r" +
                                "f�rmodligen b�sts�ljarna �nglar och demoner (2000) och Da Vinci-koden (2003). Han har �ven gett ut tv� skivor p� eget skivbolag." },
                    new Author() { Id = 3, Name = "J.R.R. Tolkien", Biography = "Tolkien har gjort sig ett namn som en av de st�rsta inom fantasy-genren och han var den "+
                                "som mer eller mindre grundade den i sin moderna form. Med sina b�cker, och d� fr�mst kanske trilogin Sagan om ringen, har han v�ckt beundran hos " +
                                "miljontals l�sare v�rlden �ver. K�nnetecknande f�r hans verk �r dess detaljrikedom och den ibland n�rmast ogreppbara blandningen av folkslag, spr�k och kulturer." +
                                "N�r han skulle visa n�gons grovhet, eller hur hemskt och fruktansv�rt n�got var, tog han p� ett magnifikt s�tt hj�lp av rollpersonerna i boken, som l�saren redan" +
                                "bekantat sig med. Ett exempel �r n�r br�draskapet m�ter en balrog, d� han ist�llet f�r att fiktivt beskriva denna best, l�ter trollkarlen Gandalf bli orolig. Gandalf "+
                                "�r vid tidpunkten mycket k�nd f�r l�saren, och p� detta s�tt f�r l�saren en inlevelsefull k�nsla av hur fruktansv�rt och m�ktigt monstret �r." },
                    new Author() { Id = 4, Name = "Niklas Gustavsson", Biography = "En av de absolut b�sta f�rfattare n�gonsin, med sina inspirerande b�cker s� som: �lr�vh�nans �ventyr i vattnadalen,"+
                                "Vilken �l i r�ven?. Niklas Gustavsson slutar aldrig f�rbrylla sina l�sare med djupa, k�nslosamma ber�ttelser om k�rlek, BDSM och �l." },
                    new Author() { Id = 5, Name = "Mikael Filipsson", Biography = "Den n�st klokaste historikern p� halva �sterlen." }
                );

            // Genres
            context.Genres.AddOrUpdate(
                    new Genre() { Id = 1, Name = "Skr�ck", Description = "L�t ljuset vara t�nt!" },
                    new Genre() { Id = 2, Name = "Thriller", Description = "Nagelbitare. L�s med vita silkeshandskar." },
                    new Genre() { Id = 3, Name = "Fantasy", Description = "Drakar, riddare och troll!" },
                    new Genre() { Id = 4, Name = "Historia", Description = "Faktab�cker om historia." }
                );

            // Books
            context.Books.AddOrUpdate(
                    new Book() { Id = 1, Title = "Sagan om Ringen", Year = 1948, Price = 49.9m, ISBN = "123-234-643-12", InStock = 46, ImagePath = "http://image.bokus.com/images2/9789172632189_200", Summary = "Hobbitar �r bara sm� p� utsidan." },
                    new Book() { Id = 2, Title = "Sk�nes Historia", Year = 1999, Price = 79.9m, ISBN = "345-371-251-121", InStock = 12, ImagePath = "http://www.esff.se/dok/dok_info/skane.gif", Summary = "J�evlett vikte bog ti � l�esa. Ell�r iallafall glo p� bild�rna." },
                    new Book() { Id = 3, Title = "Da Vinci Kodden", Year = 2006, Price = 69.9m, ISBN = "123-762-33-1274", InStock = 67, ImagePath = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Da_Vinci_Vitruve_Luc_Viatour.jpg/300px-Da_Vinci_Vitruve_Luc_Viatour.jpg", Summary = "Leonardo da Vinci gjorde visst mer �n bara uppfinna grejer." },
                    new Book() { Id = 4, Title = "�nglar och Demoner", Year = 1004, Price = 69.9m, ISBN = "373-37-4532-136", InStock = 247, ImagePath = "https://nilmasbokhylla.files.wordpress.com/2012/03/c3a4nglar-och-demoner.jpg", Summary = "En faktisk bok." },
                    new Book() { Id = 5, Title = "Det", Year = 1986, Price = 99.9m, ISBN = "532-234-137-1251", InStock = 12, ImagePath = "http://s1.discshop.se/img/front_large/33066/det_stephen_kings.jpg", Summary = "Det �r en clown. Och en rymdspindel." },
                    new Book() { Id = 6, Title = "Boktitel 6", Year = 1948, Price = 9.99m, ISBN = "123-234-643-12", InStock = 46, ImagePath = "http://image.bokus.com/images2/9789172632189_200", Summary = "Hobbitar �r bara sm� p� utsidan." },
                    new Book() { Id = 7, Title = "Boktitel 7", Year = 1948, Price = 9.99m, ISBN = "123-234-643-12", InStock = 46, ImagePath = "http://image.bokus.com/images2/9789172632189_200", Summary = "Hobbitar �r bara sm� p� utsidan." },
                    new Book() { Id = 8, Title = "Boktitel 8", Year = 1948, Price = 9.99m, ISBN = "123-234-643-12", InStock = 46, ImagePath = "http://image.bokus.com/images2/9789172632189_200", Summary = "Hobbitar �r bara sm� p� utsidan." },
                    new Book() { Id = 9, Title = "Boktitel 9", Year = 1948, Price = 9.99m, ISBN = "123-234-643-12", InStock = 46, ImagePath = "http://image.bokus.com/images2/9789172632189_200", Summary = "Hobbitar �r bara sm� p� utsidan." },
                    new Book() { Id = 10, Title = "Boktitel 10", Year = 1948, Price = 9.99m, ISBN = "123-234-643-12", InStock = 46, ImagePath = "http://image.bokus.com/images2/9789172632189_200", Summary = "Hobbitar �r bara sm� p� utsidan." },
                    new Book() { Id = 11, Title = "Boktitel 11", Year = 1948, Price = 9.99m, ISBN = "123-234-643-12", InStock = 46, ImagePath = "http://image.bokus.com/images2/9789172632189_200", Summary = "Hobbitar �r bara sm� p� utsidan." }
                );

            // Book-Author couplings
            context.BookAuthorCouplings.AddOrUpdate(
                new BookAuthorCoupling() { Id = 1, AuthorId = 3, BookId = 1 },
                new BookAuthorCoupling() { Id = 3, AuthorId = 5, BookId = 2 },
                new BookAuthorCoupling() { Id = 4, AuthorId = 2, BookId = 3 },
                new BookAuthorCoupling() { Id = 5, AuthorId = 2, BookId = 4 },
                new BookAuthorCoupling() { Id = 6, AuthorId = 1, BookId = 5 },
                new BookAuthorCoupling() { Id = 9, AuthorId = 3, BookId = 6 },
                new BookAuthorCoupling() { Id = 10, AuthorId = 3, BookId = 7 },
                new BookAuthorCoupling() { Id = 11, AuthorId = 3, BookId = 8 },
                new BookAuthorCoupling() { Id = 12, AuthorId = 3, BookId = 9 },
                new BookAuthorCoupling() { Id = 13, AuthorId = 3, BookId = 10 },
                new BookAuthorCoupling() { Id = 14, AuthorId = 3, BookId = 11 },
                new BookAuthorCoupling() { Id = 15, AuthorId = 3, BookId = 11 }
                );

            // Book-Genre couplings
            context.BookGenreCouplings.AddOrUpdate(
                new BookGenreCoupling() { Id = 1, GenreId = 3, BookId = 1 },
                new BookGenreCoupling() { Id = 3, GenreId = 1, BookId = 2 },
                new BookGenreCoupling() { Id = 4, GenreId = 2, BookId = 3 },
                new BookGenreCoupling() { Id = 5, GenreId = 2, BookId = 4 },
                new BookGenreCoupling() { Id = 6, GenreId = 1, BookId = 5 },
                new BookGenreCoupling() { Id = 9, GenreId = 3, BookId = 6 },
                new BookGenreCoupling() { Id = 10, GenreId = 3, BookId = 7 },
                new BookGenreCoupling() { Id = 11, GenreId = 3, BookId = 8 },
                new BookGenreCoupling() { Id = 12, GenreId = 3, BookId = 9 },
                new BookGenreCoupling() { Id = 13, GenreId = 3, BookId = 10 },
                new BookGenreCoupling() { Id = 14, GenreId = 3, BookId = 11 },
                new BookGenreCoupling() { Id = 15, GenreId = 3, BookId = 11 }
                );
        }
    }
}
