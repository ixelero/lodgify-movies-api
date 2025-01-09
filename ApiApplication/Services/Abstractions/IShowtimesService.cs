using ApiApplication.Services.Models;

namespace ApiApplication.Services.Abstractions;

public interface IShowtimesService
{
    Task<IList<ShowtimeModel>> GetShowtimesAsync(CancellationToken cancellationToken = default);
    Task<ShowtimeModel> GreateShowtimeAsync(ShowtimeModel model, CancellationToken cancellationToken = default);
}
