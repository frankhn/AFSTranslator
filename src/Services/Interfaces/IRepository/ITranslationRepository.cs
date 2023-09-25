using System;
using AfsTranslator.src.Repositories.Dtos;

namespace AfsTranslator.src.Services.Interfaces.IRepository
{
	public interface ITranslationRepository
	{
        List<TranslationDto> GetAll();
        TranslationDto Create(string body);
    }
}

