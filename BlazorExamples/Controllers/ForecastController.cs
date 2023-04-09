using BlazorExamples.Data;
using Microsoft.AspNetCore.Mvc;

// ToDo 2. Show
namespace BlazorExamples.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ForecastController : ControllerBase
{
    public async Task<ActionResult<IEnumerable<WeatherForecast>>> GetForecast()
    {
        var svc = new WeatherForecastService();

        return new OkObjectResult(await svc.GetForecastAsync(DateTime.Now));
    }
}
