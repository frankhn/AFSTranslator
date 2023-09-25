using System.Net;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AfsTranslator.Models;
using AfsTranslator.src.Services.Interfaces.IServices;
using AfsTranslator.src.Repositories.Models;
using System.Text.Json;
using System.Text;
using AfsTranslator.src.Repositories.Dtos;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using AutoMapper;

namespace AfsTranslator.Controllers;

public class HomeController : Controller
{

    private ITranslationLogService _translationService;

    public HomeController(ITranslationLogService translationLogService)
    {
        _translationService = translationLogService;
        
    }

    public async Task<IActionResult> Index()
    {
        List<TranslationLogDto> translationLogs = _translationService.GetAll();
        return View(translationLogs);
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

