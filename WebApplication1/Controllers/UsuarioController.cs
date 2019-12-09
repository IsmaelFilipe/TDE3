﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TDEDominio.Entidade;
using TDEServico.Services;
using TDEServico.Validadores;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class UsuarioController : ControllerBase
    {

        private BaseService<Usuario> service = new BaseService<Usuario>();


        [HttpPost]
        public IActionResult Post([FromBody] Usuario item)
        {
            try
            {
                service.Post<UsuarioValidador>(item);

                return Ok(new ObjectResult(item.CodUsuario));
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var resultado = service.Select(id);
                if (resultado == null)
                    return NotFound();
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPut]
        public IActionResult Put([FromBody]Usuario item)
        {
            try
            {
                service.Put<UsuarioValidador>(item);

                return Ok("Campanha alterado com sucesso!");
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var resultado = service.Select(id);
                if (resultado == null)
                    return NotFound();
                service.Remove(id);
                return Ok("Deleteado com sucesso" + id.ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }

}