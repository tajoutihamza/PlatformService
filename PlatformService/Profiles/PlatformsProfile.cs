using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        
        public PlatformsProfile()
        {
            //source --> target
            CreateMap<Platform,PlatformReadDto>();
            //target --> source
            CreateMap<PlatformCreateDto, Platform>();
        }


    }
}
