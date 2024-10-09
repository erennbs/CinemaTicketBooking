using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class ShowSeat {
        public int Id { get; set; }
        public int HallSeatId { get; set; }
        public bool IsReserved { get; set; }
        public int? BookingId { get; set; }
        public int ShowId { get; set; }
    }
}
