using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class Booking {
        public int Id { get; set; }
        public int NumberOfSeats { get; set; }
        public int UserId { get; set; }
    }
}
