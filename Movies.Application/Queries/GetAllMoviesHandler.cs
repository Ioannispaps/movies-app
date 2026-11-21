using MediatR;
using Movies.Application.Mappers;
using Movies.Application.Responses;
using Movies.Core.Repositories;

namespace Movies.Application.Queries;

public class GetAllMoviesHandler : IRequestHandler<GetAllMoviesQuery, IReadOnlyList<MovieResponse>>
{
    private readonly IMovieRepository _movieRepository;

    public GetAllMoviesHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<IReadOnlyList<MovieResponse>> Handle(GetAllMoviesQuery request, CancellationToken cancellationToken)
    {
        var movies = await _movieRepository.GetAllAsync();
        return movies.Select(m => m.ToResponse()).ToList();
    }
}