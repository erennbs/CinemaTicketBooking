using CinemaBooking.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBooking.Services {
    public class UserService {
        private string _connectionString { get; } = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;

        public void Add(User user) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", user.UserName);
                parameters.Add("user_pass", user.Password);
                parameters.Add("user_birthday", user.Birthday);

                connection.Query("sp_InsertUser", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(User user) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("user_id", user.Id);

                connection.Query("sp_DeleteUser", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public UserWithRoles GetUserWithRolesByCredentials(string username, string password) {
            UserWithRoles user;
            
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", username);
                parameters.Add("user_pass", password);

                user = connection.QuerySingleOrDefault<UserWithRoles>("sp_GetUserWithRolesByCredentials", param: parameters, commandType: CommandType.StoredProcedure);
            }

            return user;
        }

        public List<UserWithRoles> GetAllUsersWithRoles(string username = null) {
            List<UserWithRoles> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();

                if (!string.IsNullOrEmpty(username)) { 
                    parameters.Add("user_name", username);
                }

                list = connection.Query<UserWithRoles>("sp_GetAllUsersWithRoles", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            }

            return list;
        }

        public UserWithRoles GetUserWithRolesByUserId(int id) {
            UserWithRoles user;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_id", id);

                user = connection.QuerySingleOrDefault<UserWithRoles>("sp_GetUserWithRolesByUserId", param: parameters, commandType: CommandType.StoredProcedure);
            }

            return user;
        }

        public void Update(User user) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_id", user.Id);
                parameters.Add("user_name", user.UserName);
                parameters.Add("user_pass", user.Password);
                parameters.Add("user_birthday", user.Birthday);

                connection.Query("sp_UpdateUser", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateUserRoles(UserWithRoles entity) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@executer_user_name", loginView.UserDetails.UserName);
                parameters.Add("@role_id", entity.RoleId);
                parameters.Add("@movie_read", entity.MovieRead);
                parameters.Add("@movie_insert", entity.MovieInsert);
                parameters.Add("@movie_update", entity.MovieUpdate);
                parameters.Add("@movie_delete", entity.MovieDelete);
                parameters.Add("@booking_read", entity.BookingRead);
                parameters.Add("@booking_insert", entity.BookingInsert);
                parameters.Add("@booking_update", entity.BookingUpdate);
                parameters.Add("@booking_delete", entity.BookingDelete);
                parameters.Add("@cinema_read", entity.CinemaRead);
                parameters.Add("@cinema_insert", entity.CinemaInsert);
                parameters.Add("@cinema_update", entity.CinemaUpdate);
                parameters.Add("@cinema_delete", entity.CinemaDelete);
                parameters.Add("@cinema_hall_read", entity.CinemaHallRead);
                parameters.Add("@cinema_hall_insert", entity.CinemaHallInsert);
                parameters.Add("@cinema_hall_update", entity.CinemaHallUpdate);
                parameters.Add("@cinema_hall_delete", entity.CinemaHallDelete);
                parameters.Add("@city_read", entity.CityRead);
                parameters.Add("@city_insert", entity.CityInsert);
                parameters.Add("@city_update", entity.CityUpdate);
                parameters.Add("@city_delete", entity.CityDelete);
                parameters.Add("@genre_read", entity.GenreRead);
                parameters.Add("@genre_insert", entity.GenreInsert);
                parameters.Add("@genre_update", entity.GenreUpdate);
                parameters.Add("@genre_delete", entity.GenreDelete);
                parameters.Add("@language_read", entity.LanguageRead);
                parameters.Add("@language_insert", entity.LanguageInsert);
                parameters.Add("@language_update", entity.LanguageUpdate);
                parameters.Add("@language_delete", entity.LanguageDelete);
                parameters.Add("@show_read", entity.ShowRead);
                parameters.Add("@show_insert", entity.ShowInsert);
                parameters.Add("@show_update", entity.ShowUpdate);
                parameters.Add("@show_delete", entity.ShowDelete);
                parameters.Add("@user_read", entity.UserRead);
                parameters.Add("@user_insert", entity.UserInsert);
                parameters.Add("@user_update", entity.UserUpdate);
                parameters.Add("@user_delete", entity.UserDelete);
                parameters.Add("@role_read", entity.RoleRead);
                parameters.Add("@role_insert", entity.RoleInsert);
                parameters.Add("@role_update", entity.RoleUpdate);
                parameters.Add("@role_delete", entity.RoleDelete);
                parameters.Add("@log_read", entity.LogRead);
                parameters.Add("@report_read", entity.ReportRead);

                connection.Query("sp_UpdateRole", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<UsersWithAgeDto> GetAllUsersWithAge() {
            List<UsersWithAgeDto> list;

            using (var connection = new SqlConnection(_connectionString)) {

                list = connection.Query<UsersWithAgeDto>("sp_GetUsersWithAge", commandType: CommandType.StoredProcedure).ToList();
            }

            return list;
        }

        public List<Log> GetAllLogs() {
            List<Log> list;

            using (var connection = new SqlConnection(_connectionString)) {

                list = connection.Query<Log>("sp_GetAllLogs", commandType: CommandType.StoredProcedure).ToList();
            }

            return list;
        }
    }
}
