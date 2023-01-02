using Microsoft.EntityFrameworkCore;

namespace pat2023_lukasz_winowicz_dotnet.Entities.Database
{
    public class DatabaseContext : DbContext
    {

        public DbSet<BookDto> Books{ get; set; }
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
            modelBuilder.Entity<BookAuthor>().HasKey(x => new {x.BookId, x.AuthorId});

            // Author
            modelBuilder.Entity<Author>().HasKey(x => x.Id);
            modelBuilder.Entity<Author>().Property(fn => fn.FirstName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Author>().Property(ln => ln.LastName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Author>().Property(b => b.BirthDate).HasColumnType("datetime2").HasPrecision(0).IsRequired();
            modelBuilder.Entity<Author>().Property(g => g.Gender).HasColumnType("bit").IsRequired();

            // Book
            modelBuilder.Entity<BookDto>().HasKey(x => x.Id);
            modelBuilder.Entity<BookDto>().Property(t => t.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<BookDto>().Property(d => d.Description).IsRequired();
            modelBuilder.Entity<BookDto>().Property(r => r.Rating).HasColumnType("decimal(2,1)").IsRequired();
            modelBuilder.Entity<BookDto>().Property(i => i.ISBN).HasMaxLength(13).IsRequired();
            modelBuilder.Entity<BookDto>().Property(p => p.PublicationDate).HasColumnType("datetime2").HasPrecision(0).IsRequired();

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

            modelBuilder.Entity<BookDto>().HasData(
                new BookDto
                {
                    Id = 1,
                    Title = "1Q84 Tom 1",
                    Description = "In 1Q84 ...",
                    Rating = Convert.ToDecimal(8.2),
                    ISBN = "XXX123",
                    PublicationDate = new DateTime(1988, 1, 12),
                },
                new BookDto
                {
                    Id = 2,
                    Title = "1Q84 Tom 2",
                    Description = "In 1Q84 ...",
                    Rating = Convert.ToDecimal(7.5),
                    ISBN = "XXX124",
                    PublicationDate = new DateTime(1989, 1, 12),
                },
                new BookDto
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
