using System;
using System.Collections.Generic;

#nullable disable

namespace RomanDesafioWebAPI.Domains
{
    public partial class Tema
    {
        public Tema()
        {
            Projetos = new HashSet<Projeto>();
        }

        public int Id { get; set; }
        public string Temas { get; set; }

        public virtual ICollection<Projeto> Projetos { get; set; }
    }
}
