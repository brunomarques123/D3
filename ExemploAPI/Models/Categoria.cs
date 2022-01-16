using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ExemploAPI.Models
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }


        public Categoria(string descricao, int idCategoria = 0)
        {
            this.IdCategoria = idCategoria;
            this.Descricao = descricao;
        }



    }
}