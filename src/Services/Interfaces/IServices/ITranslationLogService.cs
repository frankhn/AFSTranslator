using System;
using AfsTranslator.src.Repositories.Dtos;

namespace AfsTranslator.src.Services.Interfaces.IServices
{
    public interface ITranslationLogService
    {
        List<TranslationLogDto> GetAll();
        TranslationLogDto Create(TranslationLogDto translationLog);
    }
}

