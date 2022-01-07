using AutoMapper;
using CommandHelper.Dtos;
using CommandHelper.Models;

namespace CommandHelper.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Command, GetCommandDto>();
            CreateMap<CreateCommandDto, Command>();
        }
    }
}