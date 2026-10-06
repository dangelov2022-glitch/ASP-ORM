using GameStoreApp.Data.Domain;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameStoreApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();

        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet <GameTag> GameTag { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet <Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
