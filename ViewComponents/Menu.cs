using LojaProdutos.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LojaProdutos.ViewComponents
{
    public class Menu : ViewComponent
    {
         public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("usuarioSessao");
            if(string.IsNullOrEmpty(sessaoUsuario))
            {
                return View();
            }
             UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

            return View(usuario);
        }
    }
}
