using Microsoft.AspNetCore.Mvc;
using SuperHeroQuotes.Api.Models;
using SuperHeroQuotes.Api.Services;

namespace SuperHeroQuotes.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class QuoteController : ControllerBase
{
    private readonly QuoteService _quoteService;

    public QuoteController(
        QuoteService quoteService)
    {
        _quoteService = quoteService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public QuoteModel Get()
    {
        return _quoteService.RandomQuote();
    }
}