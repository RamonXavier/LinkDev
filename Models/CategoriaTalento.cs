using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinkDevRamon.Models
{
    public class CategoriaTalento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<UsuarioTalento>UsuarioTalentos { get; set; }
    }
}