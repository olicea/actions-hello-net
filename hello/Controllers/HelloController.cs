using Microsoft.AspNetCore.Mvc;

namespace hello.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetHello")]
    public HelloContract Get(string message)
    {
        return new HelloContract { Message = message };
    }
}
