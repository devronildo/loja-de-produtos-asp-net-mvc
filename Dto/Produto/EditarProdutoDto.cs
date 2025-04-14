using System.ComponentModel.DataAnnotations;

namespace LojaProdutos.Dto.Produto
{
    public class EditarProdutoDto
    {
        public  int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite a marca!")]
        public string Marca { get; set; }

        public string? Foto { get; set; }

        [Required(ErrorMessage = "Digite o valor!")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Insira a quantidade!")]
        public int QuantidadeEstoque { get; set; }

        [Required(ErrorMessage = "Selecione a categoria!")]
        public int CategoriaModelId { get; set; }
    }
}
