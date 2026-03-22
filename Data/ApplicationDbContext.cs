using Microsoft.EntityFrameworkCore;
using SmartVenueBookingSystem.Models;
using System;

namespace SmartVenueBookingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Seed Venues
            modelBuilder.Entity<Venue>().HasData(
                new Venue { VenueId = 1, VenueName = "City Hall", Location = "Downtown", Capacity = 500, Availability = true, Description = "Main municipal hall", ImageUrl = "/images/cityhall.jpg" },
                new Venue { VenueId = 2, VenueName = "Grand Conference Center", Location = "Uptown", Capacity = 1200, Availability = true, Description = "Large conference venue", ImageUrl = "/images/conference.jpg" },
                new Venue { VenueId = 3, VenueName = "Expo Grounds", Location = "Suburb", Capacity = 3000, Availability = false, Description = "Outdoor expo space", ImageUrl = "/images/expo.jpg" },
                new Venue { VenueId = 4, VenueName = "Hotel Ballroom", Location = "City Center", Capacity = 600, Availability = true, Description = "Elegant ballroom", ImageUrl = "/images/ballroom.jpg" },
                new Venue { VenueId = 5, VenueName = "Community Hall", Location = "Westside", Capacity = 250, Availability = true, Description = "Local community hall", ImageUrl = "/images/community.jpg" }
            );

            // ✅ Seed Events
            modelBuilder.Entity<Event>().HasData(
                new Event { EventId = 1, EventName = "Tech Conference", EventDate = new DateTime(2026, 6, 10), EventType = "Conference", Description = "Annual technology summit", VenueId = 2, ImageUrl = "/images/tech.jpg" },
                new Event { EventId = 2, EventName = "Music Festival", EventDate = new DateTime(2026, 7, 15), EventType = "Concert", Description = "Outdoor music festival", VenueId = 3, ImageUrl = "/images/music.jpg" },
                new Event { EventId = 3, EventName = "Wedding Reception", EventDate = new DateTime(2026, 8, 20), EventType = "Wedding", Description = "Private wedding event", VenueId = 4, ImageUrl = "/images/wedding.jpg" },
                new Event { EventId = 4, EventName = "Business Expo", EventDate = new DateTime(2026, 9, 5), EventType = "Expo", Description = "Corporate exhibition", VenueId = 3, ImageUrl = "/images/expoevent.jpg" },
                new Event { EventId = 5, EventName = "Community Gathering", EventDate = new DateTime(2026, 10, 12), EventType = "Social", Description = "Neighborhood meet-up", VenueId = 5, ImageUrl = "/images/communityevent.jpg" }
            );

            // ✅ Seed Bookings
            modelBuilder.Entity<Booking>().HasData(
                new Booking { BookingId = 1, BookingDate = new DateTime(2026, 6, 10), CustomerName = "Alice Johnson", CustomerContact = "alice@example.com", EventId = 1, VenueId = 2 },
                new Booking { BookingId = 2, BookingDate = new DateTime(2026, 7, 15), CustomerName = "Brian Smith", CustomerContact = "brian.smith@example.com", EventId = 2, VenueId = 3 },
                new Booking { BookingId = 3, BookingDate = new DateTime(2026, 8, 20), CustomerName = "Cynthia Lee", CustomerContact = "cynthia@example.com", EventId = 3, VenueId = 4 },
                new Booking { BookingId = 4, BookingDate = new DateTime(2026, 9, 5), CustomerName = "David Brown", CustomerContact = "david.b@example.com", EventId = 4, VenueId = 3 },
                new Booking { BookingId = 5, BookingDate = new DateTime(2026, 10, 12), CustomerName = "Emma Davis", CustomerContact = "emma@example.com", EventId = 5, VenueId = 5 }
            );
        }
    }
}
