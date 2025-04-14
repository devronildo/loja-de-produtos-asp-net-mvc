using LojaProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaProdutos.Data
{
    public class DataContext : DbContext
    {
         
         public DataContext(DbContextOptions<DataContext> options) : base(options) { 
              
         }

        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<CategoriaModel> Categorias { get; set; }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<EnderecoModel> Enderecos { get; set; }


        public DbSet<ProdutosBaixadosModel> ProdutosBaixados { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CategoriaModel>().HasData(
                 new CategoriaModel{ Id = 1,Nome = "Tenis" },
                 new CategoriaModel { Id = 2, Nome = "Chinelos" },
                 new CategoriaModel { Id = 3, Nome = "Sandalia" },
                 new CategoriaModel { Id = 4, Nome = "Botas" },
                 new CategoriaModel { Id = 5, Nome = "Sapatos" }


             );
            base.OnModelCreating(modelBuilder);
        }

    }
}
