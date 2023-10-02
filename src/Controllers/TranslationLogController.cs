using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AfsTranslator.src.Repositories.Dtos;
using AfsTranslator.src.Repositories.Models;
using AfsTranslator.src.Services.Interfaces.IServices;
using AfsTranslator.src.Utils;
using Microsoft.AspNetCore.Mvc;

namespace AfsTranslator.src.Controllers
{
    [Route("api/[controller]")]
    public class TranslationLogController : Controller
    {

        private ITranslationLogService _translationLog;

        public TranslationLogController(ITranslationLogService translationLog)
        {
            _translationLog = translationLog;

        }


        [HttpGet]
        public List<TranslationLogDto> GetAll()
        {
            return _translationLog.GetAll();
        }


        [HttpPost]
        public async Task<IActionResult> translateText([FromBody] string value)
        {
            try
            {
                TranslationLogDto translation = await Translate.GetExternalTranslatorAsync(value);
                _translationLog.Create(translation);
                return Ok(translation);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : API Failed to translate the word");
                return BadRequest("API Failed to translate the word");
            }
        }
    }
}

