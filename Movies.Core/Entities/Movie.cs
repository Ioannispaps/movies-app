using Movies.Core.Entities.Base;

namespace Movies.Core.Entities;

public class Movie : Entity
{
    public string Title { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public int Year { get; set; }
}