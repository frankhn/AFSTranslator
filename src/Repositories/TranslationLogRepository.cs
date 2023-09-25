using System.Net;
using AutoMapper;
using AfsTranslator.src.Services.Interfaces.IRepository;
using AfsTranslator.src.Repositories.Models;
using AfsTranslator.src.Utils;
using AfsTranslator.src.Repositories.Dtos;

namespace AfsTranslator.src.Repositories
{
    public class TranslationLogRepository : ITranslationLogRepository
    {
        private readonly IMapper _mapper;
        private List<TranslationLogDto> _translationLog;
        
        public TranslationLogRepository(IMapper mapper)
        {
            _mapper = mapper;
            _translationLog = Db.translationLogs;
        }

        public TranslationLogDto Create(TranslationLogDto translationLog)
        {
            TranslationLogDto newTranslationLog = _mapper.Map<TranslationLogDto>(translationLog);
            newTranslationLog.Id = _translationLog.Max(x => x.Id) + 1;

            _translationLog.Add(newTranslationLog);
            translationLog.Id = newTranslationLog.Id;
            return translationLog;

        }

        public List<TranslationLogDto> GetAll()
        {
            List<TranslationLogDto> translationLogs = _mapper.Map<List<TranslationLogDto>>(Db.translationLogs);
            return translationLogs;
        }
    }
}

