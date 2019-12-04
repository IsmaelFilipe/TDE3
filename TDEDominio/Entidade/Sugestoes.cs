using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TDEDominio.Entidade
{
    public class Sugestoes : BaseEntity
    {
        public int CodSugestoes { get; set; }
        [ForeignKey ("Funcionario")]
        public int CodFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }
        [ForeignKey ("Campanha")]
        public int CodCampanha { get; set; }
        public Campanha Campanha { get; set; }
        public string Descrição { get; set; }
        public float Custo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public float ReduçãoCusto { get; set; }

        public ICollection<Avaliacao> Avaliacao { get; set; }
    }
}
