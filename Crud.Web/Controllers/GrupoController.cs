using Crud.Dominio.Contratos;
using Crud.Dominio.ObjetoDevalor;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Crud.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        public readonly IGrupoRepositorio _grupoRepositorio;

        public GrupoController(IGrupoRepositorio grupoRepositorio)
        {
            _grupoRepositorio = grupoRepositorio;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            try
            {
                return Ok(_grupoRepositorio.ObterTodos());
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public IActionResult Post([FromBody] Grupo grupo)
        {
            try
            {
                _grupoRepositorio.Adicionar(grupo);
                return Created("api/grupo", grupo);
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}