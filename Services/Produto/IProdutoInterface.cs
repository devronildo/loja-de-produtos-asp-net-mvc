using LojaProdutos.Dto.Produto;
using LojaProdutos.Models;

namespace LojaProdutos.Services.Produto
{
    public interface IProdutoInterface
    {
        Task<List<ProdutoModel>> BuscarProdutos();
        Task<List<ProdutoModel>> BuscarProdutoFiltro(string pesquisar);

        Task<ProdutoModel> Cadastrar(CriarProdutoDto criarProdutoDto, IFormFile foto);
        Task<ProdutoModel> BuscarProdutoPorId(int Id);

        Task<ProdutoModel> Editar(EditarProdutoDto editarProdutoDto, IFormFile foto);
        Task<ProdutoModel> Remover(int id);
       
    }
}
