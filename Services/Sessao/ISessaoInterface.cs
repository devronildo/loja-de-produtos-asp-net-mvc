using LojaProdutos.Models;

namespace LojaProdutos.Services.Sessao
{
    public interface ISessaoInterface
    {
        void CriarSessao(UsuarioModel usuarioModel);
        void RemoverSessao();
        UsuarioModel BuscarSessao();
    }
}
