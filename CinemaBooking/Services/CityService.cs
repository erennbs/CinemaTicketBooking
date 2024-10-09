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
    public class CityService {
        private string _connectionString { get; } = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;


        public void Add(City entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("city_name", entity.Name);

                connection.Query("sp_InsertCity", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(City entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("city_id", entity.Id);

                connection.Query("sp_DeleteCity", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<City> GetAll() {
            List<City> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<City>("sp_GetAllCities", commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public City GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(City entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("city_id", entity.Id);
                parameters.Add("city_name", entity.Name);

                connection.Query("sp_UpdateCity", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
