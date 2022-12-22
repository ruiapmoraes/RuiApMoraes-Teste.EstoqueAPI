using Microsoft.AspNetCore.Mvc;
using RuiMoraes.Teste.EstoqueAPI.DTOs;
using RuiMoraes.Teste.EstoqueAPI.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RuiMoraes.Teste.EstoqueAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET: api/<ProdutosController>
        [HttpGet]
        public ActionResult<IEnumerable<ProdutoDTO>> BuscaProdutos()
        {
            var produtos = _produtoService.BuscarTodos();
            if (produtos == null)
                return NotFound("Produtos não localizados");
            return Ok(produtos);
        }

        // GET api/<ProdutosController>/5
        [HttpGet("{id}", Name = "BuscarProduto")]
        public ActionResult<ProdutoDTO> BuscarProduto(int id)
        {
            var produto = _produtoService.BuscarPorId(id);
            if (produto == null)
            {
                return NotFound("Produto não encontrado");
            }
            return Ok(produto);
        }

        // POST api/<ProdutosController>
        [HttpPost]
        public ActionResult<ProdutoDTO> Post([FromBody] ProdutoDTO produtoDto)
        {
            if (produtoDto == null)
                return BadRequest("Dados inconsistentes.");

            _produtoService.Criar(produtoDto);

            return new CreatedAtRouteResult("BuscarProduto",
                new { id = produtoDto.Id }, produtoDto);
        }

        // PUT api/<ProdutosController>/5
        [HttpPut("{id}")]
        public ActionResult Editar(int id, [FromBody] ProdutoDTO produtoDto)
        {
            if (id != produtoDto.Id)
            {
                return BadRequest("Data invalid");
            }

            if (produtoDto == null)
                return BadRequest("Data invalid");

            _produtoService.Edtar(produtoDto);

            return Ok(produtoDto);
        }
    }
}
