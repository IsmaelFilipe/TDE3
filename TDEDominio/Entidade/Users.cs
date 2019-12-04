using System;
using System.Collections.Generic;
using System.Text;

namespace TDEDominio.Entidade
{
    public class Users : BaseEntity
    {
        public string UserID { get; set; }
        public string AcessKey { get; set; }
        public int userCreated { get; set; }
        public int lastUser { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public bool active { get; set; }
    }
}
