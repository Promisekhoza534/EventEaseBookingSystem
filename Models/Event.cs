using System;
using System.ComponentModel.DataAnnotations;

namespace SmartVenueBookingSystem.Models
{
    public class Event
    {
        [Key] public int EventId { get; set; }
        [Required] public string EventName { get; set; } = string.Empty;
        public DateTime EventDate { get; set; }
        public string? EventType { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int? VenueId { get; set; }
        public Venue? Venue { get; set; }
    }
}
