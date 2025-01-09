using ApiApplication.Database.Entities;
using ApiApplication.Services.Models;
using AutoMapper;

namespace ApiApplication.Mappings;

public class MoviesProfile : Profile
{
    public MoviesProfile()
    {
        CreateMap<AuditoriumEntity, AuditoriumModel>();
        CreateMap<AuditoriumModel, AuditoriumEntity>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<MovieEntity, MovieModel>();
        CreateMap<MovieModel, MovieEntity>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<SeatEntity, SeatModel>().ReverseMap();

        CreateMap<ShowtimeEntity, ShowtimeModel>();
        CreateMap<ShowtimeModel, ShowtimeEntity>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<TicketEntity, TicketModel>();
        CreateMap<TicketModel, TicketEntity>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
    }
}
