using Movies.Application.Responses;
using Movies.Core.Entities;

namespace Movies.Application.Mappers;

public static class MovieMapper
{
    public static MovieResponse ToResponse(this Movie movie)
    {
        return new MovieResponse
        {
            Id = movie.Id,
            Title = movie.Title,
            Director = movie.Director,
            Year = movie.Year
        };
    }
}