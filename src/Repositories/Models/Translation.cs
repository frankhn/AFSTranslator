using System;
using System.ComponentModel.DataAnnotations;

namespace AfsTranslator.src.Repositories.Models
{
	public class Translation
	{
        public int Id { get; set; }

        [Required]
		[MaxLength(150)]
		public string? text { get; set; }
	}
}

