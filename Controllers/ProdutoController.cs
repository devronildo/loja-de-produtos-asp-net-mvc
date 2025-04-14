using LojaProdutos.Dto.Produto;
using LojaProdutos.Filtros;
using LojaProdutos.Services.Categoria;
using LojaProdutos.Services.Produto;
using Microsoft.AspNetCore.Mvc;

namespace LojaProdutos.Controllers
{
    [UsuarioLogado]
    public class ProdutoController : Controller
    {

        private readonly IProdutoInterface _produtoInterface;
        private readonly ICategoriaInterface _categoriaInterface;
        public ProdutoController(IProdutoInterface produtoInterface,
              ICategoriaInterface categoriaInterface
            ) {
            _produtoInterface = produtoInterface;
            _categoriaInterface = categoriaInterface;
        }

        [UsuarioLogadoAdm]
        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoInterface.BuscarProdutos();

            return View(produtos);
        }

        [UsuarioLogadoAdm]
        public async Task<IActionResult> Cadastrar()
        { 
            ViewBag.Categorias = await _categoriaInterface.BuscarCategorias();

            return View();
        }
        [UsuarioLogadoAdm]
        public async Task<IActionResult> Editar(int id)
        {
            var produto = await _produtoInterface.BuscarProdutoPorId(id);

            var editarProdutoDto = new EditarProdutoDto
            {
                Nome = produto.Nome,
                Marca = produto.Marca,
                Foto = produto.Foto,
                Valor = produto.Valor,
                QuantidadeEstoque = produto.QuantidadeEstoque,
                CategoriaModelId = produto.CategoriaModelId,
            };

            ViewBag.Categorias = await _categoriaInterface.BuscarCategorias();

            return View(editarProdutoDto);
        }
        [UsuarioLogadoAdm]
        [HttpPost]
        public async Task<IActionResult> Cadastrar(CriarProdutoDto criarProdutoDto, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                var produto = await _produtoInterface.Cadastrar(criarProdutoDto, foto);
                TempData["MensagemSucesso"] = "Produto Cadastrado com sucesso!";
                return RedirectToAction("Index", "Produto");
            }else
            {
                ViewBag.Categorias = await _categoriaInterface.BuscarCategorias();
                TempData["MensagemErro"] = "Ocorreu algum erro no processo!";
                return View(criarProdutoDto);
            }
        }
        [UsuarioLogadoAdm]
        public async Task<IActionResult> Remover(int id)
        {

             var produto = await _produtoInterface.Remover(id);

             return RedirectToAction("Index", "Produto");
        }

        public async Task<IActionResult> Detalhes(int id)
        {
             var produto = await _produtoInterface.BuscarProdutoPorId(id);

            return View(produto);
        }
        [UsuarioLogadoAdm]
        [HttpPost]
        public async Task<IActionResult> Editar(EditarProdutoDto editarProdutoDto, IFormFile? foto)
        {
            if (ModelState.IsValid)
            {
                var produto = await _produtoInterface.Editar(editarProdutoDto, foto);
                TempData["MensagemSucesso"] = "Produto Editado com sucesso!";
                return RedirectToAction("Index", "Produto");

            }
            else
            {

                ViewBag.Categorias = await _categoriaInterface.BuscarCategorias();
                TempData["MensagemErro"] = "Erro ao editar produto!";
                return View(editarProdutoDto);
            }
        }


    }
}
