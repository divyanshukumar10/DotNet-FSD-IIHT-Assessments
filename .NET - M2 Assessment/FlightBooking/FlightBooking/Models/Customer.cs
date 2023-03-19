using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FlightBooking.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
