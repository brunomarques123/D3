using ExemploAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExemploAPI.Data;

namespace ExemploAPI.Services
{
    public class CategoriaService
    {    
        // entity contem dados para inserir, regra de negocio
        public bool Add(Categoria entity)
        {
            if (!string.IsNullOrEmpty(entity.Descricao))
            {
                return new CategoriasRepository().Add(entity);
            }
            else
            {
                return false;
            }
        }
        // retorna uma lista com todos os produtos do banco
        public List<Categoria> Get() 
        {
            // regra de negocio
            return new CategoriasRepository().Get();
        }


        public bool Delete(Categoria entity)
        {
            // regra de negocio
            if (entity.IdCategoria > 0)
            {
                return new CategoriasRepository().Delete(entity);
            }
            else
            {
                return false;
            }
        }

        public bool Put(Categoria entity)
        {
            // regra de negocio
            if (entity.IdCategoria > 0)
            {
                return new CategoriasRepository().Put(entity);
            }
            else
            {
                return false;
            }
        }
    }
}