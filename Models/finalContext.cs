using Microsoft.EntityFrameworkCore;

namespace final.Models
{
    public class finalContext : DbContext
    {
        public finalContext (DbContextOptions<finalContext> options)
            : base(options)
        {
        }

        public DbSet<final.Models.God> God { get; set; }
    }
}