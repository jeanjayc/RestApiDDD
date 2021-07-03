using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.App;
using RestApiModeloDDD.App.Dtos;
using RestApiModeloDDD.App.Interfaces;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IApplicationServiceCliente _applicationServiceCliente;

        public ClientesController(IApplicationServiceCliente applicationServiceCliente)
        {
            _applicationServiceCliente = applicationServiceCliente;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCliente.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClienteDTO clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();
                _applicationServiceCliente.Add(clienteDto);
                return Ok("Cliente Cadastrado com sucesso");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ClienteDTO clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();
                _applicationServiceCliente.Update(clienteDto);
                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDTO clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound();
                _applicationServiceCliente.Remove(clienteDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
