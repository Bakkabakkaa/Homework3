using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : Controller
{
    [HttpGet("post")]
    public double Plus([FromQuery] double x, [FromQuery] double y)
    {
        HttpContext.Response.StatusCode = 200;
        return x + y;
    }
    
    [HttpGet("minus")]
    public double Minus([FromQuery] double x, [FromQuery] double y)
    {
        HttpContext.Response.StatusCode = 200;
        return x - y;
    }
    
    [HttpGet("multiply/{x}/{y}")]
    public double Multiply([FromRoute] double x, [FromRoute] double y)
    {
        HttpContext.Response.StatusCode = 300;
        return x * y;
    }

    [HttpGet("divide/{x}/{y}")]
    public double Divide([FromRoute] double x, [FromRoute] double y)
    {
        HttpContext.Response.StatusCode = 300;
        return x / y;
    }
}