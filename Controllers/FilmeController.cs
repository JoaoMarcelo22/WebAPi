using WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase 
    {
        private static List<Filme>filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionarFilme([FromBody]Filme filme)
        {
          filme.Id = id++;
          filmes.Add(filme);
          return CreatedAtAction(nameof(RecuperaFilmesPorId),new { Id = filme.Id},filme);
          Console.WriteLine(filme.Titulo);
        }

        [HttpGet]
        public IActionResult RecuperarFilme()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmesPorId(int id)
        {
         Filme filme = filmes.FirstOrDefault(filme => filme.Id == id);
         if(filme != null)
         {
             return Ok(filme);
         } 
         return NotFound(); // se o id informado não retornar nada, o null será retornado
        }
    }
}