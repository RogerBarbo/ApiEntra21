using Microsoft.AspNetCore.Mvc;
using Modelo.Application.Interfaces;
using Modelo.Domain;

namespace ApiEntra21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        private readonly IAlunoApplication _alunoApplication;

        public AlunoController(IAlunoApplication alunoApplication)
        {
            _alunoApplication = alunoApplication;
        }

        [HttpGet("BuscarDadosAluno/{id}")]
        public IActionResult BuscarDadosAluno(int id)
        {
            try
            {
                var aluno = _alunoApplication.BuscarAluno(id);

                return Ok(aluno);
            }
            catch (Exception e)
            {

                return BadRequest();
            }
        }
        [HttpPost("InserirDadosAluno")]
        public IActionResult InserirDadosAluno([FromBody] Aluno aluno)
        {
            try 
            {
                _alunoApplication.InserirAluno(aluno);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPatch("AlterarDadosAluno")]
        public IActionResult AlterarDadosAluno([FromBody] Aluno aluno)
        {
            try
            {
                _alunoApplication.AlterarAluno(aluno);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest();
            }
        }

        [HttpPut("AlterarTotalDadosAluno")]
        public IActionResult AlterarTotalDadosAluno([FromBody] Aluno aluno)
        {
            try
            {
                _alunoApplication.AlterarAluno(aluno);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest();
            }
        }

        [HttpDelete("ExcluirDadosAluno/{id}")]
        public IActionResult ExcluirDadosAluno(int id)
        {
            try
            {
                _alunoApplication.ExcluirAluno(id);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest();
            }
        }
    }
}
