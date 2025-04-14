using LojaProdutos.Enums;
using LojaProdutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace LojaProdutos.Filtros
{
    public class UsuarioLogadoAdm : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            
            var sessao = context.HttpContext.Session.GetString("usuarioSessao");
            if (string.IsNullOrEmpty(sessao))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"controller", "Login"},
                    {"action", "Login" }
                });
            }
            else
            {
                UsuarioModel usuarioModel = JsonConvert.DeserializeObject<UsuarioModel>(sessao);



                if (usuarioModel.Cargo == CargoEnum.Cliente)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"controller", "Home"},
                    {"action", "Index" }
                });
                }
            }

            

            base.OnActionExecuted(context);
        }
    }
}
