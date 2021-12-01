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
    public class ProjetoRepository : IProjetoRepository
    {

        RomanContext ctx = new RomanContext();

        public void Cadastrar(Projeto novoProjeto)
        {
            ctx.Projetos.Add(novoProjeto);

            ctx.SaveChanges();
        }

        public List<Projeto> Listar()
        {
            return ctx.Projetos.Include(p => p.IdTemaNavigation).ToList();
        }
    }
}
