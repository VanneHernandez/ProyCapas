using Microsoft.AspNetCore.Mvc;
using ProyectoCapas.BLL;

namespace ProyectoCapas.Controllers.Producto
{
    public class ProductoController : Controller
    {
        private readonly ProductoService _productoService;

        public ProductoController(ProductoService productoService)
        {
            _productoService = productoService;
        }

        public IActionResult Index()
        {
            var productos = _productoService.ObtenerProductosDisponibles();
            return View(productos);
        }

        public IActionResult Detalle(int id)
        {
            var producto = _productoService.ObtenerProductoPorId(id);
            return View(producto);
        }
    }
}
