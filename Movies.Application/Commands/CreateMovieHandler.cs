using MediatR;
using Movies.Core.Entities;
using Movies.Core.Repositories;

namespace Movies.Application.Commands;

public class CreateMovieHandler : IRequestHandler<CreateMovieCommand, int>
{
    private readonly IMovieRepository _movieRepository;

    public CreateMovieHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<int> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
    {
        var movie = new Movie
        {
            Title = request.Title,
            Director = request.Director,
            Year = request.Year
        };

        var created = await _movieRepository.AddAsync(movie);
        return created.Id;
    }
}