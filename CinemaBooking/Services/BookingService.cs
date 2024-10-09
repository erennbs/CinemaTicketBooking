using CinemaBooking.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Services {
    public class BookingService {
        private string _connectionString { get; } = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;


        public Booking Add(Booking entity) {
            Booking result;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("booking_num_of_seats", entity.NumberOfSeats);
                parameters.Add("user_id", entity.UserId);

                result = connection.QuerySingle<Booking>("sp_InsertBooking", parameters, commandType: CommandType.StoredProcedure);
            }
            return result;
        }

        public void Delete(Booking entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("booking_id", entity.Id);

                connection.Query("sp_DeleteBooking", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Booking> GetAll() {
            throw new NotImplementedException();
        }

        public List<BookingDetailsDto> GetAllBookingDetails(string movie_name = null, string cinema_name = null, string hall_number = null) {
            List<BookingDetailsDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();

                if (!string.IsNullOrEmpty(movie_name)) {
                    parameters.Add("movie_name", movie_name);
                }
                if (!string.IsNullOrEmpty(cinema_name)) { 
                    parameters.Add("cinema_name", cinema_name);
                }
                if (!string.IsNullOrEmpty(hall_number)) { 
                    parameters.Add("hall_number", hall_number);
                }

                list = connection.Query<BookingDetailsDto>("sp_GetAllBookingDetails", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public Booking GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(Booking entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("booking_id", entity.NumberOfSeats);
                parameters.Add("booking_num_of_seats", entity.NumberOfSeats);
                parameters.Add("user_id", entity.UserId);

                connection.Query("sp_UpdateBooking", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
