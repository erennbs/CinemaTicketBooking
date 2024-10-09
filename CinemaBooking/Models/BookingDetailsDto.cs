using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class BookingDetailsDto {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string Username { get; set; }
        public string CinemaName { get; set; }
        public int HallNumber { get; set; }
        public string Seats { get; set; }
        public DateTime StartTime { get; set; }
    }
}
