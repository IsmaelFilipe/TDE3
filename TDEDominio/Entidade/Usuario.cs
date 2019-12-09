using System;
using System.Collections.Generic;
using System.Text;

namespace TDEDominio.Entidade
{
    public class Usuario : BaseEntity
    {
        public int CodUsuario { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
        public string CPF { get; set; }

        public ICollection<Funcionario> Funcionario { get; set; }
    }
}
