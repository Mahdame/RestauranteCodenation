﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestauranteCodenation.Data.Repositorio;
using RestauranteCodenation.Domain;

namespace RestauranteCodenation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPratoController : ControllerBase
    {
        private readonly TipoPratoRepositorio _repo;

        public TipoPratoController()
        {
            _repo = new TipoPratoRepositorio();
        }

        // GET: api/TipoPrato
        [HttpGet]
        public List<TipoPrato> Get()
        {
            return _repo.SelecionarTodos();
        }

        // GET: api/TipoPrato/5
        [HttpGet("{id}")]
        public TipoPrato Get(int id)
        {
            return _repo.SelecionarPorId(id);
        }

        // POST: api/TipoPrato
        [HttpPost]
        public TipoPrato Post([FromBody] TipoPrato tipoPrato)
        {
            _repo.Incluir(tipoPrato);
            return tipoPrato;
        }

        // PUT: api/TipoPrato/5
        [HttpPut("{id}")]
        public TipoPrato Put([FromBody] TipoPrato tipoPrato)
        {
            _repo.Alterar(tipoPrato);
            return tipoPrato;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<TipoPrato> Delete(int id)
        {
            _repo.Excluir(id);
            return _repo.SelecionarTodos();
        }
    }
}
