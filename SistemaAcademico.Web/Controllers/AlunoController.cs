using Microsoft.AspNetCore.Mvc;
using SistemaAcademico.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcademico.Web.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();

            }catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpPost("VerificarAluno")]
        public ActionResult VerificarAluno([FromBody] Aluno aluno)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
