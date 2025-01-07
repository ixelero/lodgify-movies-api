namespace ApiApplication.Database.Entities;

public class AuditoriumEntity
{
    public int Id { get; set; }
    public ICollection<ShowtimeEntity> Showtimes { get; set; }
    public ICollection<SeatEntity> Seats { get; set; }

}
