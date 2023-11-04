using Microsoft.AspNetCore.Mvc;

namespace TodoWebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class EmptyController : ControllerBase
{
    private readonly ILogger<EmptyController> _logger;

    public EmptyController(ILogger<EmptyController> logger)
    {
        _logger = logger;
    }

    [HttpGet("/hello-world")]
    public string GetMessage()
    {
        _logger.LogInformation("get");
        return "Hello, world!";
    }
}
