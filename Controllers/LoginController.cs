using LojaProdutos.Dto.Dto;
using LojaProdutos.Services.Sessao;
using LojaProdutos.Services.Usuario;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LojaProdutos.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioInterface _usuarioInterface;
        private readonly ISessaoInterface _sessaoInteface;

        public LoginController(IUsuarioInterface usuarioInterface, ISessaoInterface sessaoInteface)
        {
            _usuarioInterface = usuarioInterface;
            _sessaoInteface = sessaoInteface;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Sair()
        {
            _sessaoInteface.RemoverSessao();
            return RedirectToAction("Login", "Login");
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUsuarioDto loginUsuarioDto)
        {
            if (ModelState.IsValid)
            {
                  var usuario = await _usuarioInterface.Login(loginUsuarioDto);

                  if(usuario == null) {
                    TempData["MensagemErro"] = "Credenciais inválidas!";
                    return View(loginUsuarioDto);
                   }
                    TempData["MensagemSucesso"] = "Usuário Logado com sucesso!";
                    return RedirectToAction("Index", "Home");


            } 
            else
            {
                TempData["MensagemErro"] = "Verifique os dados informados!";
                return View(loginUsuarioDto);
            }
        }
    }
}
