using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class HallSeat {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public int HallId { get; set; }
    }
}
