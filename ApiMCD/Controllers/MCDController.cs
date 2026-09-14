using ApiMCD.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiMCD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MCDController : ControllerBase
    {
        private readonly MCDService _mcdService;

        public MCDController(MCDService mcdService)
        {
            _mcdService = mcdService;
        }

        [HttpGet("{dividendo}/{divisor}")]
        public IActionResult CalcularMCD(int dividendo, int divisor)
        {
            int resultado = _mcdService.CalcularMCD(dividendo, divisor);

            return Ok(new
            {
                Dividendo = dividendo,
                Divisor = divisor,
                MCD = resultado
            });
        }
    }
}