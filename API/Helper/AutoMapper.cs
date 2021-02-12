using API.Dtos;
using API.Models;
using AutoMapper;

namespace API.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterDto, AppUser>();
            CreateMap<Messages, MessageDto>();
        }
    }
}