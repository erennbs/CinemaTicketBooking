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
    public class LanguageService {
        private string _connectionString { get; } = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;


        public void Add(Language language) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("language_name", language.Name);

                connection.Query("sp_InsertLanguage", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(Language language) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("language_id", language.Id);

                connection.Query("sp_DeleteLanguage", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Language> GetAll() {
            List<Language> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<Language>("sp_GetAllLanguages", commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public Language GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(Language language) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("language_id", language.Id);
                parameters.Add("language_name", language.Name);

                connection.Query("sp_UpdateLanguage", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
