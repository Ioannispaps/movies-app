using Microsoft.EntityFrameworkCore;
using Movies.Core.Entities;

namespace Movies.Infrastructure.Data;

public class MovieContext : DbContext
{
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Movie>().HasData(
            new Movie { Id = 1, Title = "The Matrix", Director = "Lana Wachowski", Year = 1999 },
            new Movie { Id = 2, Title = "Inception", Director = "Christopher Nolan", Year = 2010 },
            new Movie { Id = 3, Title = "Interstellar", Director = "Christopher Nolan", Year = 2014 }
        );
    }
}