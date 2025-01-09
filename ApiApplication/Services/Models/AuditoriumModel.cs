namespace ApiApplication.Services.Models;

public class AuditoriumModel
{
    public int Id { get; set; }
    public ICollection<ShowtimeModel> Showtimes { get; set; }
    public ICollection<SeatModel> Seats { get; set; }

}
