using System.Collections.Generic;

namespace EventEase.Models
{
    public class HomeViewModel
    {
        public List<Event> UpcomingEvents { get; set; } = new List<Event>();
        public List<Booking> RecentBookings { get; set; } = new List<Booking>();
    }
}