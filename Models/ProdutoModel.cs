using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LojaProdutos.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Marca { get; set; }

        public string Foto { get; set; }

        public double Valor {  get; set; }

        public int QuantidadeEstoque { get; set; }

        public int CategoriaModelId { get; set; }

        [ValidateNever]
        public CategoriaModel Categoria {  get; set; }


    }
}
