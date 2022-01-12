using Microsoft.EntityFrameworkCore;

namespace firstwebapp.Models
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=C:\Temp\Items.db");
    }
}
