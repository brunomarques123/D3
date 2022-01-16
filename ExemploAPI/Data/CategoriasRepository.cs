using ExemploAPI.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploAPI.Data
{
    public class CategoriasRepository
    {
        public bool Add(Categoria entity)
        {
            var _conexao = new Conexao().Carregar();

            MySqlCommand comando = new MySqlCommand(
                $@"INSERT INTO CATEGORIA(descricao)
                   VALUES('{entity.Descricao}')", _conexao);

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

        public List<Categoria> Get()
        {
            var _conexao = new Conexao().Carregar();

            MySqlCommand comando = new MySqlCommand($@"SELECT * FROM CATEGORIA", _conexao);

            try
            {
                _conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                List<Categoria> values = new List<Categoria>();

                while (reader.Read())
                {
                    values.Add(new Categoria(
                        reader["Descricao"].ToString(),
                        int.Parse(reader["IdCategoria"].ToString())
                    ));
                }

                return values;
            }
            catch
            {
                return null;
            }
            finally
            {
                _conexao.Close();
            }
        }

        public bool Delete(Categoria entity)
        {
            var _conexao = new Conexao().Carregar();

            MySqlCommand comando = new MySqlCommand(
                $@"DELETE FROM CATEGORIA 
                   WHERE IdCategoria = {entity.IdCategoria}", _conexao);

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

        public bool Put(Categoria entity)
        {
            var _conexao = new Conexao().Carregar();

            MySqlCommand comando = new MySqlCommand(
                $@"UPDATE CATEGORIA SET descricao='{entity.Descricao}'
                   WHERE idCategoria = {entity.IdCategoria} ", _conexao);

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