using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.App.Dtos;
using RestApiModeloDDD.App.Interfaces;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            _applicationServiceProduto = applicationServiceProduto;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get ()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDTO produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();
                _applicationServiceProduto.Add(produtoDto);
                return Ok("Produto cadastrado com sucesso!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDTO produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();
                _applicationServiceProduto.Update(produtoDto);
                return Ok("Produto atualizado com sucesso! ");

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDTO produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();
                _applicationServiceProduto.Remove(produtoDto);
                return Ok("Produto removido com sucesso!");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
