﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class MoviesWithLengthDto{
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Length { get; set; }
    }
}
