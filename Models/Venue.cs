using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Venue
    {
        public int VenueId { get; set; }

        [Required]
        public string VenueName { get; set; } = string.Empty;

        public string? Location { get; set; }

        public int Capacity { get; set; }

        public bool Availability { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public ICollection<Event>? Events { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }
}