using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class MovieDetailsDto {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal TicketPrice { get; set; }
        public string? ImagePath { get; set; }
    }
}
