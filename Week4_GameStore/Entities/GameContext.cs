using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace Entities
{
    public class GameContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public GameContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source = localhost; Database = GameDatabase; integrated security = True;");
            // options.UseSqlServer(Configuration.GetConnectionString("GameDatabase"));


        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publisher>().ToTable("Publisher");
            modelBuilder.Entity<Game>().ToTable("Game");
        }

        public DbSet<Game> Game { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
    }
}
