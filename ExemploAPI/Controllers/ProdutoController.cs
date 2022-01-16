using ExemploAPI.Models;
using ExemploAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ExemploAPI.Controllers
{
    public class ProdutoController : ApiController
    {
        private static List<Produto> produtos = new List<Produto>();

        public List<Produto> GET() // consulta
        {
            return new ProdutoService().Get();
        }

        //adicionar
        public void Post([FromBody] Produto entity) // inserir
        {
            new ProdutoService().Add(entity);
        }

        //deletar
        public void Delete([FromBody] Produto entity) // excluir
        {
            new ProdutoService().Delete(entity);
        }

        public void Put([FromBody] Produto entity)
        {
            new ProdutoService().Put(entity);
        }
    }
}