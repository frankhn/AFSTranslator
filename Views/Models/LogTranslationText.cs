using System;
using AfsTranslator.src.Repositories.Dtos;
using AfsTranslator.src.Repositories.Models;

namespace AfsTranslator.Views.Models
{
	public class LogTranslationText
	{
		public List<TranslationLogDto>? translationLog { get; set; }

		public Translation? translation { get; set; }

	}
}

