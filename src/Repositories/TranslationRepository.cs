using System.Net;
using AutoMapper;
using AfsTranslator.src.Services.Interfaces.IRepository;
using AfsTranslator.src.Repositories.Models;
using AfsTranslator.src.Utils;
using AfsTranslator.src.Repositories.Dtos;

namespace AfsTranslator.src.Repositories
{
	public class TranslationRepository: ITranslationRepository
	{
        private readonly IMapper _mapper;
        private List<TranslationDto> _translation;

        public TranslationRepository(IMapper mapper)
        {
            _mapper = mapper;
            _translation = Db.translation;
        }

        public TranslationDto Create(string __translation)
        {
            TranslationDto newTranslation = _mapper.Map<TranslationDto>(__translation);
            newTranslation.Id = _translation.Max(x => x.Id) + 1;
            TranslationDto translation = new TranslationDto { Id = newTranslation.Id, text = __translation };
            _translation.Add(translation);
            return translation;
        }

        public List<TranslationDto> GetAll()
        {
            List<TranslationDto> translations = _mapper.Map<List<TranslationDto>>(Db.translation);
            return translations;
        }
    }
}

