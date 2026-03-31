using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required]
        public string EventName { get; set; } = string.Empty;

        public DateTime EventDate { get; set; }

        public string? EventType { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public int VenueId { get; set; }

        public Venue? Venue { get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }
}