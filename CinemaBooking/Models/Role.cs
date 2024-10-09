using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Models {
    public class Role {
        public int RoleId { get; set; }
        public bool MovieRead { get; set; }
        public bool MovieInsert { get; set; }
        public bool MovieUpdate { get; set; }
        public bool MovieDelete { get; set; }
        public bool BookingRead { get; set; }
        public bool BookingInsert { get; set; }
        public bool BookingUpdate { get; set; }
        public bool BookingDelete { get; set; }
        public bool CinemaRead { get; set; }
        public bool CinemaInsert { get; set; }
        public bool CinemaUpdate { get; set; }
        public bool CinemaDelete { get; set; }
        public bool CinemaHallRead { get; set; }
        public bool CinemaHallInsert { get; set; }
        public bool CinemaHallUpdate { get; set; }
        public bool CinemaHallDelete { get; set; }
        public bool CityRead { get; set; }
        public bool CityInsert { get; set; }
        public bool CityUpdate { get; set; }
        public bool CityDelete { get; set; }
        public bool GenreRead { get; set; }
        public bool GenreInsert { get; set; }
        public bool GenreUpdate { get; set; }
        public bool GenreDelete { get; set; }
        public bool LanguageRead { get; set; }
        public bool LanguageInsert { get; set; }
        public bool LanguageUpdate { get; set; }
        public bool LanguageDelete { get; set; }
        public bool ShowRead { get; set; }
        public bool ShowInsert { get; set; }
        public bool ShowUpdate { get; set; }
        public bool ShowDelete { get; set; }
        public bool UserRead { get; set; }
        public bool UserInsert { get; set; }
        public bool UserUpdate { get; set; }
        public bool UserDelete { get; set; }
        public bool RoleRead { get; set; }
        public bool RoleInsert { get; set; }
        public bool RoleUpdate { get; set; }
        public bool RoleDelete { get; set; }
        public bool LogRead { get; set; }
        public bool ReportRead { get; set; }
    }
}
