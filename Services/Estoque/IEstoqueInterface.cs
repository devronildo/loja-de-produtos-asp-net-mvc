using LojaProdutos.Models;

namespace LojaProdutos.Services.Estoque
{
    public interface IEstoqueInterface
    {
        Task<ProdutosBaixadosModel> CriarRegistro(int idProduto);
        List<RegistroProdutosModel> ListagemRegistros();
    }
}
