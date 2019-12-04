using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TDEDominio.Entidade
{
    public class Cadastro : BaseEntity
    {
        public int CodCadastro { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }

        [ForeignKey("Usuario")]
        public int CodUsuario { get; set; }
        public Usuario Usuario { get; set; }


    }
}
