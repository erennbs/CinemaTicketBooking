using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class UsersWithAgeDto {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }
    }
}
