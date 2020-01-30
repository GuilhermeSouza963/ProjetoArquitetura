using Arquitetura.Dominio.VendasContext.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Arquitetura.WebApp.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            var listaProdutos = _produtoService.ListarTodos();
            return View(listaProdutos);
        }
    }
}