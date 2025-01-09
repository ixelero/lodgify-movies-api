using ApiApplication.Services.Abstractions;
using ApiApplication.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiApplication.Controllers;

[ApiController]
[Route("[controller]")]
public class ShowtimesController : ControllerBase
{
    private readonly IShowtimesService _showtimesService;

    public ShowtimesController(IShowtimesService showtimesService)
    {
        _showtimesService = showtimesService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var showtimes = await _showtimesService.GetShowtimesAsync();

        return Ok(showtimes);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ShowtimeModel model)
    {
        var createdShowtime = await _showtimesService.GreateShowtimeAsync(model);

        return Created(string.Empty, createdShowtime);
    }
}
