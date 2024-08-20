using Biblioteca_Virtual.Models;
using Biblioteca_Virtual.Repositório.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_Virtual.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public CadastroController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(UsuarioModel usuario)
        {
            _usuarioRepositorio.Adicionar(usuario);
            return Redirect("/");
        }
    }
}
