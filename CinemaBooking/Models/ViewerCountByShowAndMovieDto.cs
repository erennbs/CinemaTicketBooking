using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class ViewerCountByShowAndMovieDto {
        public int ShowId { get; set; }
        public string Title { get; set; }
        public int WatchCount { get; set; }
    }
}
