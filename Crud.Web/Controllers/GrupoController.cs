using Crud.Dominio.Contratos;
using Crud.Dominio.ObjetoDevalor;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Crud.Web.Controllers
{
    public class GrupoController : Controller
    {
        private readonly IGrupoRepositorio _grupoRepositorio;
        public GrupoController(IGrupoRepositorio grupoRepositorio)
        {
            _grupoRepositorio = grupoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_grupoRepositorio.ObterTodos());
                // if (condition == false)
                //{
                //  return BadRequest("");
                //}
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Grupo grupo)
        {
            try
            {
                //var usuario = new Usuario();
                // usuario.Nome = "Luciano";
                _grupoRepositorio.Adicionar(grupo);
                return Created("api/Grupo", grupo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
