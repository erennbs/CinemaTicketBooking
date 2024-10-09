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
    public class ShowService {
        private string _connectionString { get; } = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;


        public void Add(Show show) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("show_start_time", show.StartTime);
                parameters.Add("show_end_time", show.EndTime);
                parameters.Add("movie_ID", show.MovieId);
                parameters.Add("hall_ID", show.HallId);

                connection.Query("sp_InsertShow", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(Show show) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("show_id", show.Id);

                connection.Query("sp_DeleteShow", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Show> GetAll() {
            List<Show> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<Show>("sp_GetAllShows", commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public List<ShowDetailsDto> GetAllShowDetails(string movieName = null, string cinemaName = null) {
            List<ShowDetailsDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();

                if (!string.IsNullOrEmpty(movieName)) {
                    parameters.Add("movie_name", movieName);
                }
                if (!string.IsNullOrEmpty(cinemaName)) {
                    parameters.Add("cinema_name", cinemaName);
                }

                list = connection.Query<ShowDetailsDto>("sp_GetAllShowDetails", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public List<Show> GetAllShowsByMovieNameAndDate(string movieTitle, DateTime startTime, DateTime endTime) {
            List<Show> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("movie_title", movieTitle);
                parameters.Add("start_time", startTime);
                parameters.Add("end_time", endTime);

                list = connection.Query<Show>("sp_GetAllShowsByMovieNameAndDate", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public void Update(Show show) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("show_id", show.Id);
                parameters.Add("show_start_time", show.StartTime);
                parameters.Add("show_end_time", show.EndTime);
                parameters.Add("movie_ID", show.MovieId);
                parameters.Add("hall_ID", show.HallId);

                connection.Query("sp_UpdateShow", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Show> GetAllShowsByMovieAndCinema(int movieId, int cinemaId) {
            List<Show> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("movie_id", movieId);
                parameters.Add("cinema_id", cinemaId);

                list = connection.Query<Show>("sp_GetAllShowsByMovieAndCinema", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }
        
        public List<Show> GetFutureShowsByMovieAndCinema(int movieId, int cinemaId) {
            List<Show> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("movie_id", movieId);
                parameters.Add("cinema_id", cinemaId);

                list = connection.Query<Show>("sp_GetFutureShowsByMovieAndCinema", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }
    }
}
