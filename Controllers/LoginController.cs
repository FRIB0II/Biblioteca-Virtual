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
                TempData["Mensagem"] = "Usuário não encontrado! Tente novamente.";
                return RedirectToAction("Index");
            }
            else
            {
                return Redirect("/");
            }
        }
    }
}
