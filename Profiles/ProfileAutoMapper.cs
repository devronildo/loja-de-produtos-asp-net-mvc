using AutoMapper;
using LojaProdutos.Dto.Endereco;
using LojaProdutos.Models;

namespace LojaProdutos.Profiles
{
    public class ProfileAutoMapper: Profile
    {
        public ProfileAutoMapper()
        {
            CreateMap<EnderecoModel,EditarEnderecoDto>().ReverseMap(); //endereco model pode ser transformado em editarDto
        }
    }
}
