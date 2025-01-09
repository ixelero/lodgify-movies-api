namespace ApiApplication.Services.Models;

public class ShowtimeModel
{
    public int Id { get; set; }
    public MovieModel Movie { get; set; }
    public DateTime SessionDate { get; set; }
    public int AuditoriumId { get; set; }
    public ICollection<TicketModel> Tickets { get; set; }
}
