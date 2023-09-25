using System;
using AfsTranslator.src.Services.Interfaces.IServices;
using AfsTranslator.src.Services.Interfaces.IRepository;
using AfsTranslator.src.Services;
using AfsTranslator.src.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AfsTranslator
{
	public static class IOExtensions
	{
		public static void RegisterServices(this IServiceCollection services)
		{
			services.AddTransient<ITranslationLogService, TranslationLogService>();
			services.AddTransient<ITranslationService, TranslationService>();
        }

		public static void RegisterRepository(this IServiceCollection services)
		{
			services.AddTransient<ITranslationLogRepository, TranslationLogRepository>();
			services.AddTransient<ITranslationRepository, TranslationRepository>();
        }
	}
}

