using System;
using System.Data.SqlClient;

namespace Biblioteca.DAO
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();


        public Conexao() 
        {
            con.ConnectionString = "server=127.0.1.1;ui=desenvolvimento;pwd=$8h&1a]PKh.J;database =clioteca";
        }

        public SqlConnection conectar() 
        {
            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }
            return con;
        }
        public void desconectar() 
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }

    }
}
