using Microsoft.EntityFrameworkCore;

namespace Week10.Models
{
    public class TripLogContext : DbContext
    {
        public TripLogContext(DbContextOptions<TripLogContext> options)
            : base(options) { }

        public DbSet<Trip> Trips { get; set; }

    }
}
