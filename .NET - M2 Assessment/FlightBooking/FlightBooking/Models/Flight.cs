using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlightBooking.Models
{
    public class Flight
    {
        public int FlightID { get; set; }
        [Display(Name = "Flight Number")]
        public string FlightNumber { get; set; }
        [Display(Name = "Departing From")]
        public string DepartingFrom { get; set; }
        public string Destination { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
