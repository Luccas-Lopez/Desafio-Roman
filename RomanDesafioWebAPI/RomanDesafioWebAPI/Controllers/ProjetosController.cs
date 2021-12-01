using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RomanDesafioWebAPI.Domains;
using RomanDesafioWebAPI.Interfaces;
using RomanDesafioWebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RomanDesafioWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetosController : ControllerBase
    {
        private IProjetoRepository _projetoRepository { get; set; }

        public ProjetosController()
        {
            _projetoRepository = new ProjetoRepository();
        }


        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_projetoRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }




        [HttpPost]
        public IActionResult Cadastro(Projeto novoProjeto)
        {
            try
            {
                _projetoRepository.Cadastrar(novoProjeto);
                return StatusCode(201);
            }
            catch (Exception erro)
            {

                return BadRequest(erro);
            }

        }


    }
}
