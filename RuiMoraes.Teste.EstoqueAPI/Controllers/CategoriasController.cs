using Microsoft.AspNetCore.Mvc;
using RuiMoraes.Teste.EstoqueAPI.DTOs;
using RuiMoraes.Teste.EstoqueAPI.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RuiMoraes.Teste.EstoqueAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriasController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        // GET: api/<CategoriasController>
        [HttpGet]
        public ActionResult< IEnumerable<CategoriaDTO>> BuscarTodos()
        {
            var categorias = _categoriaService.BuscarTodos();
            if (categorias == null)            
                return NotFound("Não foram encontradas nenhum tipo de Categorias.");
            
            return Ok(categorias);
        }

        // GET api/<CategoriasController>/5
        [HttpGet("{id:int}", Name = "BuscarCategoria")]
        public ActionResult<CategoriaDTO> BuscarPorId(int id)
        {
            var categoria = _categoriaService.BuscarPorId(id);
            if (categoria == null)            
                return NotFound("Não foi encontrada a categoria selecionada.");
            return Ok(categoria);               
        }

        // POST api/<CategoriasController>
        [HttpPost]
        public ActionResult<CategoriaDTO> Adicionar([FromBody] CategoriaDTO categoriaDTO)
        {
            if (categoriaDTO == null)
                return BadRequest("Inconsistência na criação da categoria.");

            _categoriaService.Criar(categoriaDTO);
            return new CreatedAtRouteResult("BuscarCategoria", new {id = categoriaDTO.Id}, categoriaDTO);
        }

        // PUT api/<CategoriasController>/5
        [HttpPut("{id}")]
        public ActionResult<CategoriaDTO> Put(int id, [FromBody] CategoriaDTO categoriaDTO)
        {
            if (id != categoriaDTO.Id)
                return BadRequest();

            if (categoriaDTO == null)
                return BadRequest();

             _categoriaService.Editar(categoriaDTO);

            return Ok(categoriaDTO);
        }

       
    }
}
