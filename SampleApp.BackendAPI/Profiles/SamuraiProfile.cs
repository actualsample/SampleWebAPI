using AutoMapper;
using SampleApp.BackendAPI.Dto;
using SampleApp.BackendAPI.Models;

namespace SampleApp.BackendAPI.Profiles
{
    public class SamuraiProfile : Profile
    {
        public SamuraiProfile()
        {
            CreateMap<Samurai, SamuraiReadDto>();
            CreateMap<SamuraiInsertDto, Samurai>();
            CreateMap<SamuraiUpdateDto, Samurai>();
            CreateMap<Samurai,SamuraiWithQuotesReadDto>();
            CreateMap<Quote,QuoteReadDto>();
        }
    }
}
