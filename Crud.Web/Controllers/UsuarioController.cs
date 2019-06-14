using Crud.Dominio.Contratos;
using Crud.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Crud.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet("Usuario/Get")]
        public IActionResult Get()
        {
            try
            {

                return Ok(_usuarioRepositorio.ObterTodos());
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
        public IActionResult Post([FromBody]Usuario usuario)
        {
            try
            {
                //var usuario = new Usuario();
                // usuario.Nome = "Luciano";
                _usuarioRepositorio.Adicionar(usuario);
                return Created("api/Usuario", usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
