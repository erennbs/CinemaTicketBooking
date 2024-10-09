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
    public class CinemaService {
        private string _connectionString { get; } = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;


        public void Add(Cinema entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("cinema_name", entity.Name);
                parameters.Add("city_ID", entity.CityId);

                connection.Query("sp_InsertCinema", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(Cinema entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("cinema_id", entity.Id);

                connection.Query("sp_DeleteCinema", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Cinema> GetAll() {
            List<Cinema> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<Cinema>("sp_GetAllCinemas", commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public List<CinemaDetailsDto> GetAllCinemaDetails(string cityName = null) {
            List<CinemaDetailsDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();

                if (!string.IsNullOrEmpty(cityName)) { 
                    parameters.Add("city_name", cityName);
                }

                list = connection.Query<CinemaDetailsDto>("sp_GetAllCinemaDetails", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public Cinema GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(Cinema entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("cinema_id", entity.Id);
                parameters.Add("cinema_name", entity.Name);
                parameters.Add("city_ID", entity.CityId);

                connection.Query("sp_UpdateCinema", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
