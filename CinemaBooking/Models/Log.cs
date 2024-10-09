using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class Log {
        public int Id { get; set; }
        public string Username { get; set; }
        public string ProccessType { get; set; }
        public string ProccessTable { get; set; }
        public string ProccessData { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
