using Microsoft.EntityFrameworkCore;
using TripsLog.Models;

namespace TripsLog.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Trip>().HasData(
                new Trip { 
                    TripId = 1,
                    Destination = "afc",
                    Accommodation = "AFC",
                    StartDate = Convert.ToDateTime("02/02/1998"),
                    EndDate = Convert.ToDateTime("01/01/1999"),
                    AccommodationEmail = "jdal@dajiwl.com",
                    AccommodationPhone = "2443243324",
                    ThingToDo1 = "dwhilaw",
                    ThingToDo2 = "dawwda",
                    ThingToDo3 = "dwnhuadwlio"
                }

            );
        }
    }
}
