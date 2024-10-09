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
    public class ShowSeatService {
        private string _connectionString { get; } = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;


        public void Add(ShowSeat entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("hall_seat_ID", entity.HallSeatId);
                parameters.Add("is_reserved", entity.IsReserved);
                parameters.Add("booking_ID", entity.BookingId);
                parameters.Add("show_ID", entity.ShowId);


                connection.Query("sp_InsertShowSeat", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(ShowSeat entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("show_seat_id", entity.Id);

                connection.Query("sp_DeleteShowSeat", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<ShowSeat> GetAll() {
            throw new NotImplementedException();
        }

        public List<ShowSeatDetailsDto> GetAllShowSeatsByShowId(int showId) {
            List<ShowSeatDetailsDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("show_ID", showId);

                list = connection.Query<ShowSeatDetailsDto>("sp_GetAllShowSeatsByShowId", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public ShowSeat GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(ShowSeat entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("show_seat_id", entity.Id);
                parameters.Add("hall_seat_ID", entity.HallSeatId);
                parameters.Add("is_reserved", entity.IsReserved);
                parameters.Add("booking_ID", entity.BookingId);
                parameters.Add("show_ID", entity.ShowId);

                connection.Query("sp_UpdateShowSeat", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
