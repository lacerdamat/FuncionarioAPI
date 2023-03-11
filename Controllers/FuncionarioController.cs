using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using funcionario;

namespace funcionario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        static Dictionary<int,Funcionario> Empregados = new Dictionary<int,Funcionario>();

        [HttpPost]
        public IActionResult EmpregarFuncionario(Funcionario funcionario){
            Empregados.Add(funcionario.Id, funcionario);
            return Ok(funcionario);
        }
        [HttpDelete("{id}")]
        public IActionResult DesempregarFuncionario (int id){
            Empregados.Remove(id);
            return (Ok());
        }
        
        [HttpGet("{id}")]
        public IActionResult PegarFuncionario (int id){
            return (Ok(Empregados[id]));
        }

        [HttpPost]
        public IActionResult AtualizarFuncionario (int id, Funcionario funcatt){
            Empregados[id].Nome = funcatt.Nome;
            Empregados[id].DataDeAdmissao = funcatt.DataDeAdmissao;
            Empregados[id].Departamento = funcatt.Departamento;
            Empregados[id].EmailProfissional = funcatt.EmailProfissional;
            Empregados[id].Endereco = funcatt.Endereco;
            Empregados[id].Ramal = funcatt.Ramal;
            Empregados[id].Salario = funcatt.Salario;
            return Ok(Empregados[id]);
        }

        
    }
}