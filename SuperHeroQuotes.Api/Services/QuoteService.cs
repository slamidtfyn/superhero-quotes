using System.Reflection;
using System.Text.Json;
using SuperHeroQuotes.Api.Models;

namespace SuperHeroQuotes.Api.Services;

public class QuoteService
{
    private readonly Random _random;

    public QuoteService()
    {
        _random = new Random();
    }

    private IReadOnlyList<QuoteModel> Quotes { get; } = 
        JsonSerializer.Deserialize<IReadOnlyList<QuoteModel>>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "quotes.json")), new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        }) ??
        throw new ApplicationException("Quotes not loaded");

    public QuoteModel RandomQuote()
    {
        var index = _random.Next(Quotes.Count + 1);
        return Quotes[index];
        
    }
}