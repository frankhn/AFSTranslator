using System;
namespace AfsTranslator.src.Repositories.Dtos
{
    public class TranslationLogDto
    {
        public int Id { get; set; }
        public string? OriginalText { get; set; }
        public string? TranslatedText { get; set; }
        public string? Translation { get; set; }
        public DateTime Timestamp { get; set; }
    }
}

