using Homework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : Controller
{
    [HttpPost("post")]
    public double Plus([FromBody] Operands operands)
    {
        HttpContext.Response.StatusCode = 200;
        return operands.X + operands.Y;
    }
    
    [HttpPost("minus")]
    public double Minus([FromBody] Operands operands)
    {
        HttpContext.Response.StatusCode = 200;
        return operands.X - operands.Y;
    }
    
    [HttpPost("multiply")]
    public double Multiply([FromBody] Operands operands)
    {
        HttpContext.Response.StatusCode = 300;
        return operands.X * operands.Y;
    }

    [HttpPost("divide")]
    public double Divide([FromBody] Operands operands)
    {
        HttpContext.Response.StatusCode = 300;
        return operands.X / operands.Y;
    }
    
    [HttpPost("divideWithCheck")]
    public IActionResult DividedWithCheck([FromBody] Operands operands)
    {
        if (operands.Y == 0)
        {
            return BadRequest("Делить на ноль нельзя");
        }

        return Ok(operands.X / operands.Y);
    }
}