using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkDevRamon.Models
{
    public class UsuarioTalento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public virtual CategoriaTalento CategoriaTalento { get; set; }
    }
}