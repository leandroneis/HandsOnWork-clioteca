using System;
using MySql.Data.MySqlClient;


namespace Biblioteca.DAO
{
    public static class FabricaDeConexaoDAO
    {

        private static MySqlConnection conexao;
        private static MySqlConnectionStringBuilder conexaoSDB;

        public static MySqlConnection conectar()
        {
            try
            {
                conexaoSDB = new MySqlConnectionStringBuilder();
                conexaoSDB.Server = "127.0.1.1";
                conexaoSDB.Database = "clioteca";
                conexaoSDB.UserID = "desenvolvimento";
                conexaoSDB.Password = "$8h&1a]PKh.J";
                conexao = new MySqlConnection(conexaoSDB.ToString());
                conexao.Open();
                Console.WriteLine("Conexão com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível conectar ao banco de dados" + ex);
            }
            finally {
                desconectar();
                conexao = null;
            }
            return conexao;
        }


        public static void desconectar() {
                if (conexao != null) {
                    conexao.Close();
                }
            }
       
        

    }
}
