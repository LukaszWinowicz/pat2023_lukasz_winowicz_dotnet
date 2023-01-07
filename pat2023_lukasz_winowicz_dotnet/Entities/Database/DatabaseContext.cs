using Microsoft.EntityFrameworkCore;

namespace pat2023_lukasz_winowicz_dotnet.Entities.Database
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Book> Books{ get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors{ get; set; }

        public DatabaseContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=localhost;database=BookDb;trusted_connection=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // BookAuthor
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new {ba.BookId, ba.AuthorId});
            modelBuilder.Entity<BookAuthor>().HasOne(ba => ba.Book).WithMany(b => b.BookAuthors).HasForeignKey(ba => ba.BookId);
            modelBuilder.Entity<BookAuthor>().HasOne(ba => ba.Book).WithMany(a => a.BookAuthors).HasForeignKey(ba => ba.BookId);

            // Author
            modelBuilder.Entity<Author>().HasKey(a => a.Id);
            modelBuilder.Entity<Author>().Property(fn => fn.FirstName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Author>().Property(ln => ln.LastName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Author>().Property(b => b.BirthDate).HasColumnType("datetime2").HasPrecision(0).IsRequired();
            modelBuilder.Entity<Author>().Property(g => g.Gender).HasColumnType("bit").IsRequired();

            // Book
            modelBuilder.Entity<Book>().HasKey(b => b.Id);
            modelBuilder.Entity<Book>().Property(t => t.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Book>().Property(d => d.Description).IsRequired();
            modelBuilder.Entity<Book>().Property(r => r.Rating).HasColumnType("decimal(2,1)").IsRequired();
            modelBuilder.Entity<Book>().Property(i => i.ISBN).HasMaxLength(13).IsRequired();
            modelBuilder.Entity<Book>().Property(p => p.PublicationDate).HasColumnType("datetime2").HasPrecision(0).IsRequired();

            // Data Seeding
            modelBuilder.Entity<Author>().HasData(
                            new Author
                            {
                                Id = 1,
                                FirstName = "Haruki",
                                LastName = "Murakami",
                                BirthDate = new DateTime(1949, 1, 12),
                                Gender = false
                            },
                            new Author
                            {
                                Id = 2,
                                FirstName = "J.R.R.",
                                LastName = "Tolkien",
                                BirthDate = new DateTime(1892, 1, 3),
                                Gender = false
                            });

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "1Q84 Tom 1",
                    Description = "In 1Q84 ...",
                    Rating = Convert.ToDecimal(8.2),
                    ISBN = "XXX123",
                    PublicationDate = new DateTime(1988, 1, 12),
                },
                new Book
                {
                    Id = 2,
                    Title = "1Q84 Tom 2",
                    Description = "In 1Q84 ...",
                    Rating = Convert.ToDecimal(7.5),
                    ISBN = "XXX124",
                    PublicationDate = new DateTime(1989, 1, 12),
                },
                new Book
                {
                    Id = 3,
                    Title = "Hobbit",
                    Description = "Bilbo was...",
                    Rating = Convert.ToDecimal(9.5),
                    ISBN = "XXX125",
                    PublicationDate = new DateTime(1925, 11, 12),
                });

            modelBuilder.Entity<BookAuthor>().HasData(
                new BookAuthor
                {
                    AuthorId = 1,
                    BookId = 1
                },
                new BookAuthor
                {
                    AuthorId = 1,
                    BookId = 2
                },
                new BookAuthor
                {
                    AuthorId = 2,
                    BookId = 3
                });
        }
    }
}
