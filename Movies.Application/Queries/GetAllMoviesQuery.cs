using MediatR;
using Movies.Application.Responses;

namespace Movies.Application.Queries;

public record GetAllMoviesQuery() : IRequest<IReadOnlyList<MovieResponse>>;