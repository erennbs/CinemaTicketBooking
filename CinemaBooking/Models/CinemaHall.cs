using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class CinemaHall {
        public int Id { get; set; }
        public int Number { get; set; }
        public int CinemaId { get; set; }
        public int TotalSeats { get; set; }
    }
}
