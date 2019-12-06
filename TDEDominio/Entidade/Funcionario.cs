using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TDEDominio.Entidade
{
    public class Funcionario : BaseEntity
    {
        public int CodFuncionario { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        [ForeignKey("Usuario")]
        public int CodUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<Avaliacao> Avaliacao { get; set; }
        public ICollection<Campanha> Campanha { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Sugestoes> Sugestoes { get; set; }
    }
}
