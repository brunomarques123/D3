using ExemploAPI.Data;
using ExemploAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ExemploAPI.Services
{
    public class ProdutoService
    {
        public bool Add(Produto entity) // entity contem os dados produto pra inserir
        {
            // regra de negocio
            if (!string.IsNullOrEmpty(entity.NomeProduto) && entity.IdCategoria > 0)
            {
                return new ProdutosRepository().Add(entity);
            }
            else
            {
                return false;
            }
        }

        public List<Produto> Get() // retorna uma lista com todos os produtos do banco
        {
            // regra de negocio
            return new ProdutosRepository().Get();
        }

        public bool Delete(Produto entity) 
        {
            // regra de negocio
            if (entity.IdProduto > 0)
            {
                return new ProdutosRepository().Delete(entity);
            }
            else
            {
                return false;
            }
        }

        public bool Put(Produto entity)
        {
            // regra de negocio
            if (entity.IdProduto > 0 && entity.IdCategoria > 0)
            {
               
                return new ProdutosRepository().Put(entity);
            }
            else
            {
                return false;
            }
        }
    }
}