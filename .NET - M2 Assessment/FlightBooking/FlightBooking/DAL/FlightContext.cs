using FlightBooking.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FlightBooking.DAL
{
    public class FlightContext : DbContext
    {

        public FlightContext() : base("FlightContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}