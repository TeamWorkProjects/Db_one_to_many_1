using Microsoft.EntityFrameworkCore;

namespace One_to_one
{
    public class dbmodel : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("server=localhost;user=SA;password=Kleopatra2017@@;database=Test;trusted_connection=false");
           // optionsBuilder.UseInMemoryDatabase("baza");
        }
    }
}