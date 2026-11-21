using MediatR;

namespace Movies.Application.Commands;

public record CreateMovieCommand(string Title, string Director, int Year) : IRequest<int>;