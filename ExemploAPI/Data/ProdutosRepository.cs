using ExemploAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ExemploAPI.Data
{
    public class ProdutosRepository
    {
        public bool Add(Produto entity)
        {
            var _conexao = new Conexao().Carregar();

            MySqlCommand comando = new MySqlCommand(
                $@"INSERT INTO PRODUTOS(descricao, preco, marca, idcategoria)
                   VALUES('{entity.NomeProduto}','{entity.PrecoProduto.ToString().Replace(",", ".")}','{entity.MarcaProduto}', {entity.IdCategoria})", _conexao);

            try
            {
                _conexao.Open();
                comando.ExecuteReader();
                return true;
            }
            catch (Exception erro)
            {
                return false;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public List<Produto> Get()
        {
            var _conexao = new Conexao().Carregar();

            MySqlCommand comando = new MySqlCommand($@"SELECT * FROM PRODUTOS", _conexao);

            try
            {
                _conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                List<Produto> values = new List<Produto>();

                while (reader.Read())
                {
                    values.Add(new Produto(
                        reader["Descricao"].ToString(),
                        decimal.Parse(reader["Preco"].ToString()),
                        reader["Marca"].ToString(),
                        int.Parse(reader["IdCategoria"].ToString()),
                        int.Parse(reader["IdProdutos"].ToString())


                    ));
                }

                return values;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public bool Delete(Produto entity)
        {
            var _conexao = new Conexao().Carregar();

            MySqlCommand comando = new MySqlCommand(
                $@"DELETE FROM PRODUTOS 
                   WHERE idProdutos = {entity.IdProduto}", _conexao);

            try
            {
                _conexao.Open();
                comando.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public bool Put(Produto entity)
        {
            var _conexao = new Conexao().Carregar();

            MySqlCommand comando = new MySqlCommand(
                $@"UPDATE PRODUTOS SET descricao='{entity.NomeProduto}',preco='{entity.PrecoProduto.ToString().Replace(",", ".")}', marca='{entity.MarcaProduto}', idcategoria={entity.IdCategoria} 
                   WHERE idProdutos = {entity.IdProduto} ", _conexao);

            try
            {
                _conexao.Open();
                comando.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _conexao.Close();
            }

        }
    }
}