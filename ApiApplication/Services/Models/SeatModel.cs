namespace ApiApplication.Services.Models;

public class SeatModel
{
    public short Row { get; set; }
    public short SeatNumber { get; set; }
    public int AuditoriumId { get; set; }
    public AuditoriumModel Auditorium { get; set; }
}
