using ApiApplication.Database.Entities;
using ApiApplication.Database.Repositories.Abstractions;
using ApiApplication.Services.Abstractions;
using ApiApplication.Services.Models;
using AutoMapper;

namespace ApiApplication.Services;

public class ShowtimesService : IShowtimesService
{
    private readonly IShowtimesRepository _showtimesRepository;

    private readonly IMapper _mapper;

    public ShowtimesService(
        IShowtimesRepository showtimesRepository,
        IMapper mapper)
    {
        _showtimesRepository = showtimesRepository;
        _mapper = mapper;
    }

    public async Task<IList<ShowtimeModel>> GetShowtimesAsync(CancellationToken cancellationToken = default)
    {
        var result = await _showtimesRepository.GetAllAsync(null, cancellationToken);

        return _mapper.Map<IList<ShowtimeModel>>(result);
    }

    public async Task<ShowtimeModel> GreateShowtimeAsync(
        ShowtimeModel model,
        CancellationToken cancellationToken = default)
    {
        var showtimeEntity = _mapper.Map<ShowtimeEntity>(model);

        var createdShowtime = await _showtimesRepository.CreateShowtime(showtimeEntity, cancellationToken);

        return _mapper.Map<ShowtimeModel>(createdShowtime);
    }
}
