using System;
using AfsTranslator.src.Repositories.Dtos;
namespace AfsTranslator.src.Utils
{
	public static class Db
	{
		public static List<TranslationLogDto> translationLogs = new() {
			new TranslationLogDto{ Id=1, OriginalText = "something", TranslatedText = "Something", Translation="yoda", Timestamp = DateTime.Now },
			new TranslationLogDto{ Id=2, OriginalText = "the second", TranslatedText = "Something",  Translation="yoda",Timestamp = DateTime.Now },
			new TranslationLogDto{ Id=3, OriginalText = "the third", TranslatedText = "Something", Translation="yoda", Timestamp = DateTime.Now },
			new TranslationLogDto{ Id=4, OriginalText = "the fourth", TranslatedText = "Something",  Translation="yoda",Timestamp = DateTime.Now },
			new TranslationLogDto{ Id=5, OriginalText = "fifth", TranslatedText = "Something",  Translation="yoda",Timestamp = DateTime.Now }
		};

        public static List<TranslationDto> translation = new() {
            new TranslationDto{ Id=1, text = "something" },
            new TranslationDto{ Id=2, text = "something" },
        };

    }
}

