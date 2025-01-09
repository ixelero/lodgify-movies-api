namespace ApiApplication.Services.Models;

public class TicketModel
{
    public Guid Id { get; set; }
    public int ShowtimeId { get; set; }
    public ICollection<SeatModel> Seats { get; set; }
    public DateTime CreatedTime { get; set; }
    public bool Paid { get; set; }
    public ShowtimeModel Showtime { get; set; }
}
