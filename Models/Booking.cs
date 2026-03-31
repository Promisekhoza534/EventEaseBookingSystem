using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public DateTime BookingDate { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerContact { get; set; }

        public int EventId { get; set; }

        public int VenueId { get; set; }

        public Event? Event { get; set; }

        public Venue? Venue { get; set; }
    }
}