using Homework.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : Controller
{
    [HttpPost("plus")]
    public IActionResult Plus([FromBody] Operands operands)
    {
        var formula = new Formula
        {
            X = operands.X,
            Y = operands.Y,
            Result = operands.X + operands.Y,
            Operation = "plus"
        };
        
        return Ok(formula);
    }
    
    [HttpPost("minus")]
    public IActionResult Minus([FromBody] Operands operands)
    {
        var formula = new Formula
        {
            X = operands.X,
            Y = operands.Y,
            Result = operands.X - operands.Y,
            Operation = "minus"
        };
        
        return Ok(formula);
    }
    
    [HttpPost("multiply")]
    public IActionResult Multiply([FromBody] Operands operands)
    {
        var formula = new Formula
        {
            X = operands.X,
            Y = operands.Y,
            Result = operands.X * operands.Y,
            Operation = "multiply"
        };
        
        return Ok(formula);
    }

    [HttpPost("divide")]
    public IActionResult Divide([FromBody] Operands operands)
    {
        var formula = new Formula
        {
            X = operands.X,
            Y = operands.Y,
            Result = operands.X / operands.Y,
            Operation = "divide"
        };
        
        return Ok(formula);
    }
    
    [HttpPost("divideWithCheck")]
    public IActionResult DividedWithCheck([FromBody] Operands operands)
    {
        if (operands.Y == 0)
        {
            return BadRequest("Делить на ноль нельзя");
        }

        var formula = new Formula
        {
            X = operands.X,
            Y = operands.Y,
            Result = operands.X / operands.Y,
            Operation = "divideWithCheck"
        };
        
        return Ok(formula);
    }
}