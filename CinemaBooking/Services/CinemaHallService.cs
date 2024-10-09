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
    public class CinemaHallService {
        private string _connectionString { get; } = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;


        public void Add(CinemaHall entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("hall_number", entity.Number);
                parameters.Add("cinema_ID", entity.CinemaId);
                parameters.Add("total_seats", entity.TotalSeats);

                connection.Query("sp_InsertCinemaHall", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(CinemaHall entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("hall_id", entity.Id);

                connection.Query("sp_DeleteCinemaHall", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<CinemaHall> GetAll() {
            List<CinemaHall> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<CinemaHall>("sp_GetAllCinemaHalls", commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public List<CinemaHallDetailsDto> GetAllCinemaHallDetails() {
            List<CinemaHallDetailsDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<CinemaHallDetailsDto>("sp_GetAllCinemaHallDetails", commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public List<CinemaHall> GetAllCinemaHallsByCinemaId(int cinemaId) {
            List<CinemaHall> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("cinema_ID", cinemaId);

                list = connection.Query<CinemaHall>("sp_GetAllCinemaHallsByCinemaId", parameters, commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public CinemaHall GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(CinemaHall entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("hall_id", entity.Id);
                parameters.Add("hall_number", entity.Number);
                parameters.Add("cinema_ID", entity.CinemaId);
                parameters.Add("total_seats", entity.TotalSeats);

                connection.Query("sp_UpdateShow", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
