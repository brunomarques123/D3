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
    public class CategoriaController : ApiController
    {
        private static List<Categoria> categoria = new List<Categoria>();

        //consulta
        public List<Categoria> GET() 
        {
            return new CategoriaService().Get();
        }

        //adicionar
        public void Post([FromBody] Categoria entity)
        {
            new CategoriaService().Add(entity);
        }


        // excluir
        public void Delete([FromBody] Categoria entity) 
        {
            new CategoriaService().Delete(entity);
        }

        public void Put([FromBody] Categoria entity)
        {
            new CategoriaService().Put(entity);
        }
    }
}