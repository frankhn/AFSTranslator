using AfsTranslator.src.Repositories.Dtos;
using AfsTranslator.src.Services.Interfaces.IRepository;
using AfsTranslator.src.Services.Interfaces.IServices;

namespace AfsTranslator.src.Services
{
    public class TranslationLogService : ITranslationLogService
    {
        private readonly ITranslationLogRepository _translationLogRepository;


        public TranslationLogService(ITranslationLogRepository translationLog)
        {
            _translationLogRepository = translationLog;
        }

        public TranslationLogDto Create(TranslationLogDto translationLog)
        {
            return _translationLogRepository.Create(translationLog);
        }

        public List<TranslationLogDto> GetAll()
        {
            return _translationLogRepository.GetAll();
        }
    }
}