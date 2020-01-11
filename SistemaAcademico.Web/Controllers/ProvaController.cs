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

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_provaRepositorio.ObterTodos());
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
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
    }
}
