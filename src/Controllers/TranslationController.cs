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
    public class TranslationController : Controller
    {

        private ITranslationService _translation;

        public TranslationController(ITranslationService translation)
        {
            _translation = translation;

        }

        [HttpGet]
        public List<TranslationDto> GetAllTranslationRecords()
        {
            return _translation.GetAll();
        }
    }
}

