using System;
namespace AfsTranslator.src.Repositories.Models
{
    public class TranslationLog
    {
        public int Id { get; set; }
        public string? OriginalText { get; set; }
        public string? TranslatedText { get; set; }
        public string? Translation { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
