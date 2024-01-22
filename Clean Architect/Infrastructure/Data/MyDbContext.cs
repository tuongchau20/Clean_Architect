using Clean_Architect.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clean_Architect.Infrastructure.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
