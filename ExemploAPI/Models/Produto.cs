using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ExemploAPI.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal? PrecoProduto { get; set; }
        public string MarcaProduto { get; set; }
        public int IdCategoria { get; set; }

        public Produto(string nomeProduto, decimal precoProduto, string marcaProduto, int idCategoria, int idProduto = 0)
        {
            this.IdProduto = idProduto;
            this.NomeProduto = nomeProduto;
            this.PrecoProduto = precoProduto;
            this.MarcaProduto = marcaProduto;
            this.IdCategoria = idCategoria;
        }
    }
}