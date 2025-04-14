using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LojaProdutos.Models
{
    public class ProdutosBaixadosModel
    {
        public int Id { get; set; }

        public int ProdutoModelId { get; set; }

        [ValidateNever]
        public ProdutoModel Produto { get; set; }

        public DateTime DataDaBaixa { get; set; } = DateTime.Today; 
    }
}
