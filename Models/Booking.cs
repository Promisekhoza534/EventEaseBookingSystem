using System;
using System.ComponentModel.DataAnnotations;

namespace SmartVenueBookingSystem.Models
{
    public class Booking
    {
        [Key] public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        [Required] public string CustomerName { get; set; } = string.Empty;
        [Required] public string CustomerContact { get; set; } = string.Empty;
        public int EventId { get; set; }
        public Event? Event { get; set; }
        public int VenueId { get; set; }
        public Venue? Venue { get; set; }
    }
}
