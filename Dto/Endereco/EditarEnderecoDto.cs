namespace LojaProdutos.Dto.Endereco
{
    public class EditarEnderecoDto
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string? Complemento { get; set; }
        public int UsuarioModelId { get; set; }
       
    }
}
