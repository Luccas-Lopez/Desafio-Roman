using System;
using System.Collections.Generic;

#nullable disable

namespace RomanDesafioWebAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Projetos = new HashSet<Projeto>();
        }

        public int Id { get; set; }
        public int IdTipousuario { get; set; }
        public string NomeUsu { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipousuarioNavigation { get; set; }
        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}
