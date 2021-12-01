using System;
using System.Collections.Generic;

#nullable disable

namespace RomanDesafioWebAPI.Domains
{
    public partial class Projeto
    {
        public int Id { get; set; }
        public int IdTema { get; set; }
        public int IdUsuario { get; set; }
        public string NomePro { get; set; }
        public string DescricaoPro { get; set; }

        public virtual Tema IdTemaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
