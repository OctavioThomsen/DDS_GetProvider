using backEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModeloController: Controller
    {
        [HttpGet("GetModelos")]
        public async Task<IActionResult> GetModelos()
        {
            try
            {
                ModeloService modeloService = new();
                var listaModelos = await modeloService.GetModelos();

                return Ok(listaModelos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
