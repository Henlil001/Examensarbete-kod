using AutoMapper;
using dotnet_api.Models;

namespace dotnet_api.DTO.Mapper
{
    public class HockeyPlayerProfile : Profile
    {
        public HockeyPlayerProfile()
        {
            CreateMap<AddPlayerDTO, HockeyPlayer>();
        }
    }
}
