using CV.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CV.Api.Controllers
{
    [ApiController]
    [Route("api/tax")]
    public class TaxApiController : ControllerBase
    {
        private readonly ITaxCalculatorService _taxService;

        public TaxApiController(ITaxCalculatorService taxService)
        {
            _taxService = taxService;
        }

        [HttpGet("calculate")]
        public IActionResult Calculate([FromQuery] decimal salary)
        {
            try
            {
                var tax = _taxService.Calculate(salary);
                return Ok(new { Salary = salary, Tax = tax });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = ex.Message });
            }
        }

    }
}
