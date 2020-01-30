using Arquitetura.Dominio.VendasContext.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Arquitetura.WebApp.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            var listaCategorias = _categoriaService.ListarTodos();

            return View(listaCategorias);
        }


    }
}