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
    public class GenreService {
        private string _connectionString { get; } = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;

        public void Add(Genre genre) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("genre_name", genre.Name);

                connection.Query("sp_InsertGenre", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(Genre genre) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("genre_id", genre.Id);

                connection.Query("sp_DeleteGenre", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Genre> GetAll() {
            List<Genre> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<Genre>("sp_GetAllGenres", commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public Genre GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(Genre genre) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("genre_id", genre.Id);
                parameters.Add("genre_name", genre.Name);

                connection.Query("sp_UpdateGenre", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
