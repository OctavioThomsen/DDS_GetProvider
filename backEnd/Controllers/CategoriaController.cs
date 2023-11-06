using backEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController: Controller
    {
        [HttpGet("GetCategorias")]
        public async Task<IActionResult> GetCategorias()
        {
            try
            {
                CategoriaService categoriaService = new();
                var listaCategorias = await categoriaService.GetCategorias();

                return Ok(listaCategorias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
