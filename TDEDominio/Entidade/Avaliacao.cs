using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TDEDominio.Entidade
{
    public class Avaliacao : BaseEntity
    {
        [ForeignKey("Campanha")]
        public int CodCampanha { get; set; }
        public Campanha Campanha { get; set; }

        [ForeignKey("Funcionario")]
        public int CodFuncionario { get; set; }
        public Funcionario Funcionario { get; set; }

        [ForeignKey("Sugestoes")]
        public int CodSugestoes { get; set; }
        public Sugestoes Sugestoes { get; set; }
        public string Criatividade { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public float ReducaoCusto { get; set; }
        public float Investimento { get; set; }

    }
}
