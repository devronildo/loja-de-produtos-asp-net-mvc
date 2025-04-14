using LojaProdutos.Models;
using Newtonsoft.Json;

namespace LojaProdutos.Services.Sessao
{
    public class SessaoService : ISessaoInterface
    {
        private readonly IHttpContextAccessor _ctx;

        public SessaoService(IHttpContextAccessor ctx)
        {
            _ctx = ctx;
        }
        public UsuarioModel BuscarSessao()
        {
            string sessaoUsuario = _ctx.HttpContext.Session.GetString("usuarioSessao");

            if (string.IsNullOrEmpty(sessaoUsuario))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
        }

        public void CriarSessao(UsuarioModel usuario)
        {
            string usuarioJson = JsonConvert.SerializeObject(usuario); //converte usuario em json
            _ctx.HttpContext.Session.SetString("usuarioSessao", usuarioJson);
        }

        public void RemoverSessao()
        {
            _ctx.HttpContext.Session.Remove("usuarioSessao");
        }
    }
}
