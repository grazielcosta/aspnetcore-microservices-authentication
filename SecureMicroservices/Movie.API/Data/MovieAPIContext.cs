using Microsoft.EntityFrameworkCore;

namespace Movies.API.Data
{
    public class MovieAPIContext : DbContext
    {
        public MovieAPIContext (DbContextOptions<MovieAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Movies.API.Models.Movie> Movie { get; set; }
    }
}
