using GestaoDeProdutos.Application.Interfaces;
using GestaoDeProdutos.Application.ViewModels;
using GestaoDeProdutos.Domain.Entities;
using GestaoDeProdutos.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProdutos.WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        #region - Metódos CRUD

        #region - GET

        [HttpGet("OBTERTODOS")]
        public IActionResult Get()
        {
            return Ok(_produtoService.ObterTodos());
        }


        [HttpGet("OBTERPORID{ID}")]
        public IActionResult GetPorId(Guid id)
        {
            return Ok(_produtoService.ObterPorId(id));
        }


        [HttpGet("OBTERPORNOME{NOME}")]
        public IActionResult GetPorNome(string nome)
        {
            return Ok(_produtoService.ObterPorNome(nome));
        }


        #endregion


        #region - POST

        [HttpPost("ADICIONAR")]
        public async Task<IActionResult> Post(NovoProdutoViewModel novoProdutoViewModel)
        {
            await _produtoService.Adicionar(novoProdutoViewModel);

            return Ok("Produto criado com sucesso");
        }

        #endregion


        #region - PUT

        [HttpPut("ATUALIZAR{ID}")]
        public async Task<IActionResult> Put(Guid id, AtualizarProdutoViewModel produto)
        {
            await _produtoService.Atualizar(id, produto);

            return Ok("Atualizado com sucesso !");
        }


        [HttpPut("DESATIVAR{ID}")]
        public async Task<IActionResult> PutDesativar(Guid id)
        {
            await _produtoService.Desativar(id);

            return Ok("Desativado com sucesso !");
        }


        [HttpPut("REATIVAR{ID}")]
        public async Task<IActionResult> PutReativar(Guid id)
        {
            await _produtoService.Reativar(id);

            return Ok("Reativado !");
        }


        [HttpPut("ALTERARVALOR{ID}{VALOR}")]
        public async Task<IActionResult> PutAlterarPreco(Guid id, decimal valor)
        {
            await _produtoService.AlterarPreco(id, valor);

            return Ok("Preço do produto alterado !");
        }


        [HttpPut("ATUALIZARESTOQUE{ID}{QUANTIDADE}")]
        public async Task<IActionResult> PutAtualizarEstoque(Guid id, int quantidade)
        {
            await _produtoService.AtualizarEstoque(id, quantidade);

            return Ok("Estoque atualizado com sucesso");
        }

        #endregion

        #endregion
    }
}
