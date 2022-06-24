using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private static readonly string[] Cities = new[]
    {
        "Vienna", "Copenhagen", "Zurich", "Geneva", "Frankfurt"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public CityForecast Get()
    {
        var city = Cities[Random.Shared.Next(Cities.Length)];
        var weatherForecasts= Enumerable.Range(0, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index).ToString("D"),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
        })
        .ToArray();
        return new CityForecast()
        {
            City = city,
            WeatherForecasts = weatherForecasts
        };
    }
}
