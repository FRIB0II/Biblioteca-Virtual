using Biblioteca_Virtual.Models;
using Biblioteca_Virtual.Repositório.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_Virtual.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FazerLogin(string Email, string Senha)
        {
            UsuarioModel retorno = _usuarioRepositorio.BuscarPorEmailESenha(Email, Senha);

            if (retorno == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Redirect("/");
            }
        }
    }
}
