using backEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController: Controller
    {
        [HttpGet("GetMarcas")]
        public async Task<IActionResult> GetMarcas()
        {
            try
            {
                MarcaService marcaService = new();
                var listaMarcas = await marcaService.GetMarcas();

                return Ok(listaMarcas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
