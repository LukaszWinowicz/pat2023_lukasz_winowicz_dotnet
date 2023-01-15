using Microsoft.EntityFrameworkCore;
using pat2023_lukasz_winowicz_dotnet.Entities.SampleData;

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
            modelBuilder.Entity<BookAuthor>().HasOne(ba => ba.Author).WithMany(a => a.BookAuthors).HasForeignKey(ba => ba.AuthorId);

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
            modelBuilder.Entity<Author>().HasData(AuthorsSampleData.sampleAuthors);

            modelBuilder.Entity<Book>().HasData(BooksSampleData.sampleBooks);

            modelBuilder.Entity<BookAuthor>().HasData(BookAuthorsSampleData.sampleBookAuthors);
        }
    }
}
