using Microsoft.EntityFrameworkCore;
using Movies.Core.Entities;
using Movies.Core.Repositories;
using Movies.Infrastructure.Data;
using Movies.Infrastructure.Repositories.Base;

namespace Movies.Infrastructure.Repositories;

public class MovieRepository : Repository<Movie>, IMovieRepository
{
    public MovieRepository(MovieContext context) : base(context)
    {
    }

    public async Task<IReadOnlyList<Movie>> GetByDirectorAsync(string director)
    {
        return await _context.Movies
            .Where(m => m.Director == director)
            .ToListAsync();
    }
}