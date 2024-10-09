using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class ShowDetailsDto {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string CinemaName { get; set; }
        public int Hall { get; set; }
    }
}
