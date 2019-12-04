using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TDEDominio.Entidade
{
    public class Endereco : BaseEntity
    {
        public int CodEndereco { get; set; }

        [ForeignKey("Funcionario")]
        public int CodFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int CEP { get; set; }
    }
}
