using backEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController: Controller
    {
        [HttpGet("GetProductos")]
        public async Task<IActionResult> GetProducto()
        {
            try
            {
                ProductoService productoService = new();
                var listaProductos = await productoService.GetProductos();

                return Ok(listaProductos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
