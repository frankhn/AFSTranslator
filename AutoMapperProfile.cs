using AutoMapper;
using AfsTranslator.src.Repositories.Dtos;
using AfsTranslator.src.Repositories.Models;

namespace AfsTranslator
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TranslationLog, TranslationLogDto>().ReverseMap();

        }
    }
}

