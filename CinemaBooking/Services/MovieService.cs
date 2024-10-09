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
    public class MovieService {
        private string _connectionString { get; } = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;


        public void Add(Movie movie) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("@movie_title", movie.Title);
                parameters.Add("@movie_description", movie.Description);
                parameters.Add("@movie_duration", movie.Duration);
                parameters.Add("@movie_language_ID", movie.LanguageId);
                parameters.Add("@movie_release_date", movie.ReleaseDate);
                parameters.Add("@movie_genre_ID", movie.GenreId);
                parameters.Add("@movie_ticket_price", movie.TicketPrice);
                parameters.Add("@movie_image_path", movie.ImagePath);

                connection.Query("sp_InsertMovie", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void Delete(Movie movie) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("movie_id", movie.Id);

                connection.Query("sp_DeleteMovie", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Movie> GetAll() {
            List<Movie> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<Movie>("sp_GetAllMovies", commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public List<MovieDetailsDto> GetAllMovieDetails(string language = null, string genre = null) {
            List<MovieDetailsDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                
                if (!string.IsNullOrEmpty(language)) {
                    parameters.Add("language_name", language);
                }
                if (!string.IsNullOrEmpty(genre)) {
                    parameters.Add("genre_name", genre);
                }


                list = connection.Query<MovieDetailsDto>("sp_GetAllMovieDetails", param:parameters, commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public List<MovieTitlesDto> GetAllMovieTitles() {
            List<MovieTitlesDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<MovieTitlesDto>("sp_GetAllMovieTitles", commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public MovieDetailsDto GetMovieDetailsById(int id) {
            MovieDetailsDto movieDetailsDto;

            using (var connection = new SqlConnection(_connectionString)) {
                movieDetailsDto = connection.QuerySingleOrDefault<MovieDetailsDto>("sp_GetMovieDetailsById", commandType: CommandType.StoredProcedure);
            }
            return movieDetailsDto;
        }

        public void Update(Movie movie) {
            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("user_name", loginView.UserDetails.UserName);
                parameters.Add("@movie_id", movie.Id);
                parameters.Add("@movie_title", movie.Title);
                parameters.Add("@movie_description", movie.Description);
                parameters.Add("@movie_duration", movie.Duration);
                parameters.Add("@movie_language_ID", movie.LanguageId);
                parameters.Add("@movie_release_date", movie.ReleaseDate);
                parameters.Add("@movie_genre_ID", movie.GenreId);
                parameters.Add("@movie_ticket_price", movie.TicketPrice);
                parameters.Add("@movie_image_path", movie.ImagePath);

                connection.Query("sp_UpdateMovie", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<MovieTitlesDto> GetAllMovieTitlesOfCinema(int cinemaId) {
            List<MovieTitlesDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@cinema_id", cinemaId);
                
                list = connection.Query<MovieTitlesDto>("sp_GetAllMovieTitlesOfCinema", param: parameters, commandType: CommandType.StoredProcedure).ToList();
            }
            return list;
        }

        public List<TopMoviesDto> GetTop5MostWatchedMovies() {
            List<TopMoviesDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<TopMoviesDto>("sp_GetTop5MostWatchedMovie", commandType: CommandType.StoredProcedure).ToList();
            }

            return list;
        }
         
        public List<TopMoviesDto> GetTop5LeastWatchedMovies() {
            List<TopMoviesDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<TopMoviesDto>("sp_GetTop5LeastWatchedMovie", commandType: CommandType.StoredProcedure).ToList();
            }

            return list;
        }

        public List<MoviesWithLengthDto> GetAllMoviesWithLengths() {
            List<MoviesWithLengthDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<MoviesWithLengthDto>("sp_GetMoviesWithLength", commandType: CommandType.StoredProcedure).ToList();
            }

            return list;
        }

        public List<MovieCountByLanguageDto> GetAllMovieCountByLanguage() {
            List<MovieCountByLanguageDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<MovieCountByLanguageDto>("sp_GetMovieCountsByLanguage", commandType: CommandType.StoredProcedure).ToList();
            }

            return list;
        }

        public List<ViewerCountByShowAndMovieDto> GetAllViewerCountByShowAndMovie() {
            List<ViewerCountByShowAndMovieDto> list;

            using (var connection = new SqlConnection(_connectionString)) {
                list = connection.Query<ViewerCountByShowAndMovieDto>("sp_GetViewerCountByShowAndMovie", commandType: CommandType.StoredProcedure).ToList();
            }

            return list;
        }
    }
}
