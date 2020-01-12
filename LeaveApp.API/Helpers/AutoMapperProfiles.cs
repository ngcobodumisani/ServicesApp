using System.Linq;
using AutoMapper;
using LeaveApp.API.Dtos;
using LeaveApp.API.Models;

namespace LeaveApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.PhotoUrl, opt =>
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
            .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<User, UserForDatailedDto>()
            .ForMember(dest => dest.PhotoUrl, opt =>
            opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url))
              .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotosForDetailedDto>();
        }
    }
}