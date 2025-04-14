using LojaProdutos.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LojaProdutos.Dto.Produto
{
    public class CriarProdutoDto
    {

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
