using AfsTranslator.src.Repositories.Dtos;
using AfsTranslator.src.Services.Interfaces.IRepository;
using AfsTranslator.src.Services.Interfaces.IServices;

namespace AfsTranslator.src.Services
{
	public class TranslationService: ITranslationService
	{
        private readonly ITranslationRepository _translationRepository;


        public TranslationService(ITranslationRepository translation)
        {
            _translationRepository = translation;
        }

        public TranslationDto Create(string translation)
        {
            return _translationRepository.Create(translation);
        }

        public List<TranslationDto> GetAll()
        {
            return _translationRepository.GetAll();
        }
    }
}

