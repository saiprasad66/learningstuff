using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace WebApplication2.Models
{
    public class Moviecontext:DbContext
    {
        public Moviecontext(DbContextOptions options) : base(options) { }
        
            public DbSet<Movies> movies { get; set; }
        
    }
}
