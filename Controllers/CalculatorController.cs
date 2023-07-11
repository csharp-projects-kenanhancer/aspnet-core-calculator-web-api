using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_calculator_web_api.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Perform x + y
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>Sum of x and y.</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /Calculator/add/1/2
    ///
    /// </remarks>
    /// <response code="200">Sum of x and y.</response>
    /// <response code="400">If the item is null</response>
    [HttpGet("add/{x}/{y}")]
    public int Add(int x, int y)
    {
        _logger.LogInformation($"{x} plus {y} is {x + y}");
        return x + y;
    }

    /// <summary>
    /// Perform x - y.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>x subtract y</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /Calculator/subtract/1/2
    ///
    /// </remarks>
    /// <response code="200">Subtraction of x and y.</response>
    /// <response code="400">If the item is null</response>
    [HttpGet("subtract/{x}/{y}")]
    public int Subtract(int x, int y)
    {
        _logger.LogInformation($"{x} subtract {y} is {x - y}");
        return x - y;
    }

    /// <summary>
    /// Perform x * y.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>x multiply y</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /Calculator/multiply/1/2
    ///
    /// </remarks>
    /// <response code="200">Multiplication of x and y.</response>
    /// <response code="400">If the item is null</response>
    [HttpGet("multiply/{x}/{y}")]
    public int Multiply(int x, int y)
    {
        _logger.LogInformation($"{x} multiply {y} is {x * y}");
        return x * y;
    }

    /// <summary>
    /// Perform x / y.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>x divide y</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /Calculator/divide/1/2
    ///
    /// </remarks>
    /// <response code="200">Division of x and y.</response>
    /// <response code="400">If the item is null</response>
    [HttpGet("divide/{x}/{y}")]
    public int Divide(int x, int y)
    {
        _logger.LogInformation($"{x} divide {y} is {x / y}");
        return x / y;
    }
}