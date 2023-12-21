using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using website.Models;

namespace website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<Data.ApplicationDbContext> options)
            : base(options)
        {
        }

       public DbSet<website.Models.Ticket>Ticket { get; set; }
       public DbSet<website.Models.Flight> Flight{ get; set; }
       public DbSet<website.Models.Passenger>? Passenger { get; set; }
       public DbSet<website.Models.Payment>? Payment { get; set; }
    }
}