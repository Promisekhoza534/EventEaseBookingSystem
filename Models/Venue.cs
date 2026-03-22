using System.ComponentModel.DataAnnotations;

namespace SmartVenueBookingSystem.Models
{
    public class Venue
    {
        [Key] public int VenueId { get; set; }
        [Required] public string VenueName { get; set; } = string.Empty;
        [Required] public string Location { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public bool Availability { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
    }
}
