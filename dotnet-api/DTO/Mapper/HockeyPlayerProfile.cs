using AutoMapper;
using dotnet_api.Models;

namespace dotnet_api.DTO.Mapper
{
    public class HockeyPlayerProfile : Profile
    {
        protected HockeyPlayerProfile()
        {
            CreateMap<AddPlayerDTO, HockeyPlayer>();
        }
    }
}
