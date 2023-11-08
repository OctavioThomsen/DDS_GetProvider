using backEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoriaController: Controller
    {
        [HttpGet("GetSubcategorias")]
        public async Task<IActionResult> GetSubcategorias()
        {
            try
            {
                SubcategoriaService subcategoriaService = new();
                var listaSubcategorias = await subcategoriaService.GetSubcategorias();

                return Ok(listaSubcategorias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
