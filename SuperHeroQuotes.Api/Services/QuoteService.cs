using System.Reflection;
using System.Text.Json;
using SuperHeroQuotes.Api.Models;

namespace SuperHeroQuotes.Api.Services;

public class QuoteService
{
    private IReadOnlyList<QuoteModel> Quotes { get; } = 
        JsonSerializer.Deserialize<IReadOnlyList<QuoteModel>>(File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "quotes.json")), new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        }) ??
        throw new ApplicationException("Quotes not loaded");

    public QuoteModel RandomQuote()
    {
        var random = new Random();
        var index = random.Next(Quotes.Count);
        return Quotes[index];
        
    }
}