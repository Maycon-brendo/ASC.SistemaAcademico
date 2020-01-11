using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.Dominio.Contratos;
using SistemaAcademico.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcademico.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProvaController : Controller
    {
        private readonly IProvaRepositorio _provaRepositorio;
        public ProvaController(IProvaRepositorio provaRepositorio)
        {
            _provaRepositorio = provaRepositorio;

        }

        [HttpGet("GetClassificados")]
        public IActionResult GetClassificados()
        {
            try
            {
                return Ok(VerificarClassificados());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao buscar dados na base");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Prova prova)
        {
            try
            {
                
                _provaRepositorio.Adicionar(prova);
                return Created("api/prova", prova);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // POST: api/Prova/DefinirCampeao
        [HttpPost("DefinirCampeao")]
        public async Task<ActionResult<Aluno>> DefinirCampeao([FromBody] List<Aluno> alunos)
        {
            Aluno alunoCampeao = new Aluno();
            try
            {
                SimularCampeaoCompeticao(alunos, alunoCampeao);

                //_context.Alunos.Add(alunoCampeao);
                //await _context.SaveChangesAsync();
                return Ok(alunoCampeao);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        private void SimularCampeaoCompeticao(List<Aluno> alunos, Aluno alunoCampeao)
        {
            throw new NotImplementedException();
        }

        private List<Aluno> VerificarClassificados()
        {
            //aqui vai verificar os alunos com maiores médias ponderadas
            return new List<Aluno>();
        }
    }
}
