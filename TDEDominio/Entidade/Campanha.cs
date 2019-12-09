using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TDEDominio.Entidade
{
    public class Campanha : BaseEntity
    {
        public int CodCampanha { get; set; }
        [ForeignKey("Funcionario")]
        public int CodFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
        public string Nome { get; set; }
        public string Tema { get; set; }
        public DateTime DataInicio { get; set; }
        public int Premio { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFim { get; set; }

        public ICollection<Avaliacao> Avaliacao { get; set; }
        public ICollection<Sugestoes> Sugestoes { get; set; }
    }
}
