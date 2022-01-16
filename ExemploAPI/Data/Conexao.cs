using MySql.Data.MySqlClient;

namespace ExemploAPI.Data
{
    public class Conexao
    {
        public MySqlConnection Carregar()
        {
            return new MySqlConnection("server=localhost;User Id=root;database=banco_teste; password=bmc0785");
        }
    }
}