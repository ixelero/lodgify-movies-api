namespace ApiApplication.Services.Models;

public class MovieModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImdbId { get; set; }
    public string Stars { get; set; }
    public DateTime ReleaseDate { get; set; }
    public ICollection<ShowtimeModel> Showtimes { get; set; }
}
