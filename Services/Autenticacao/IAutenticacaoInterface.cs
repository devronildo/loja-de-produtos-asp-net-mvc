namespace LojaProdutos.Services.Autenticacao
{
    public interface IAutenticacaoInterface
    {
        void CriarSenhaHash(string senha, out byte[] senhaHash, out byte[] senhaSalt);
        bool VerificaLogin(string senha, byte[] senhaHash, byte[] senhaSalt);
    }
}
