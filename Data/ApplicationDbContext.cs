using Microsoft.EntityFrameworkCore;
using EventEase.Models;

namespace EventEase.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<EventType> EventTypes { get; set; }

        public DbSet<BookingDetailsViewModel> BookingDetailsView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
            modelBuilder.Entity<Event>()
                .HasOne(e => e.Venue)
                .WithMany(v => v.Events)
                .HasForeignKey(e => e.VenueId)
                .OnDelete(DeleteBehavior.Restrict);

          
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Event)
                .WithMany(e => e.Bookings)
                .HasForeignKey(b => b.EventId)
                .OnDelete(DeleteBehavior.Restrict);

         
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Venue)
                .WithMany(v => v.Bookings)
                .HasForeignKey(b => b.VenueId)
                .OnDelete(DeleteBehavior.Restrict);

           
            modelBuilder.Entity<BookingDetailsViewModel>()
                .HasNoKey()
                .ToView("BookingDetailsView");

           
            modelBuilder.Entity<Event>()
                .HasOne(e => e.EventTypeNavigation)
                .WithMany(et => et.Events)
                .HasForeignKey(e => e.EventTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EventType>().HasData(
                new EventType
                {
                    EventTypeId = 1,
                    EventTypeName = "Conference"
                },
                new EventType
                {
                    EventTypeId = 2,
                    EventTypeName = "Wedding"
                },
                new EventType
                {
                    EventTypeId = 3,
                    EventTypeName = "Concert"
                },
                new EventType
                {
                    EventTypeId = 4,
                    EventTypeName = "Workshop"
                },
                new EventType
                {
                    EventTypeId = 5,
                    EventTypeName = "Birthday"
                },
                new EventType
                {
                    EventTypeId = 6,
                    EventTypeName = "Corporate"
                }
            );
        }
    }
}
