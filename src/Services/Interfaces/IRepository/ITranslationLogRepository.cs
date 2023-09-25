using System;
using AfsTranslator.src.Repositories.Dtos;

namespace AfsTranslator.src.Services.Interfaces.IRepository
{
	public interface ITranslationLogRepository {

		List<TranslationLogDto> GetAll();
		TranslationLogDto Create(TranslationLogDto body);
	}
}

