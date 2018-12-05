using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using final.Models;

namespace Final.Models
{
    public class FinalContext : DbContext
    {
        public FinalContext (DbContextOptions<FinalContext> options)
            : base(options)
        {
        }

        public DbSet<final.Models.God> God { get; set; }

        public DbSet<final.Models.Country> Country { get; set; }

        public DbSet<final.Models.Hero> Hero { get; set; }
    }
}
