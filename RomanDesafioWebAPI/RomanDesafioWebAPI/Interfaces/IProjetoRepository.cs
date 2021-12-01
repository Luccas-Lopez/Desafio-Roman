using RomanDesafioWebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanDesafioWebAPI.Interfaces
{
    interface IProjetoRepository
    {
        List<Projeto> Listar();

        void Cadastrar(Projeto novoProjeto);
    }
}
