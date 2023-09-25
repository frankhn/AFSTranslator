using System;
using AfsTranslator.src.Repositories.Dtos;

namespace AfsTranslator.src.Services.Interfaces.IServices
{
    public interface ITranslationService
    {
        List<TranslationDto> GetAll();
        TranslationDto Create(string translation);
    }
}

