using Microsoft.EntityFrameworkCore;
using RomanDesafioWebAPI.Context;
using RomanDesafioWebAPI.Domains;
using RomanDesafioWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanDesafioWebAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        RomanContext ctx = new RomanContext();

        public Usuario Logar(string email, string senha)
        {
            return ctx.Usuarios.Include(u => u.IdTipousuarioNavigation).FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
