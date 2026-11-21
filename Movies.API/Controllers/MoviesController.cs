using MediatR;
using Microsoft.AspNetCore.Mvc;
using Movies.Application.Commands;
using Movies.Application.Queries;

namespace Movies.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMediator _mediator;

    public MoviesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetAllMoviesQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateMovieCommand command)
    {
        var id = await _mediator.Send(command);
        return Ok(id);
    }
}