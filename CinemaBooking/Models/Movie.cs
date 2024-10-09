using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class Movie {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int LanguageId { get; set; }
        public int GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal TicketPrice { get; set; }
        public string ImagePath { get; set; }
    }
}
