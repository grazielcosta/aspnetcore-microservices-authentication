using Movies.Client.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movieList = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "Meu malvado favorigo",
                    Genre = "comics",
                    Rating ="9.2",
                    Owner ="swn",
                    ReleaseDate = DateTime.Now,
                    ImageUrl = "images/src"
                }
            };

            return await Task.FromResult(movieList);
        }

        public Task<Movie> CreateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteMovie(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Movie> GetMovie(string id)
        {
            throw new System.NotImplementedException();
        }



        public Task<Movie> UpdateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}
