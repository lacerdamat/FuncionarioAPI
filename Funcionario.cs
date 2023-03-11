using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace funcionario
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Ramal { get; set; }
        public string EmailProfissional { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public DateTime DataDeAdmissao { get; set; }

    }
}