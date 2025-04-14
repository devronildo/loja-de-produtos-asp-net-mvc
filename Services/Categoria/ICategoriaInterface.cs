using LojaProdutos.Models;

namespace LojaProdutos.Services.Categoria
{
    public interface ICategoriaInterface
    {
        Task<List<CategoriaModel>> BuscarCategorias();
        
    }
}
