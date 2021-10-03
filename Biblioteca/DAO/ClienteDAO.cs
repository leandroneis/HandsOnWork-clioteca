using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca.Model;
using MySql.Data.MySqlClient;

namespace Biblioteca.DAO
{
    public class ClienteDAO
    {
        private String query;
        private readonly String MENSAGEM_CONEXAO_FALHOU = "Não foi possível conectar ao banco de dados!";

        public List<Cliente> Pesquisar(Cliente cliente)
        {
            try
            {
                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = conn.CreateCommand();
                query = "SELECT CODIGO,NOME_COMPLETO,EMAIL,TELEFONE,ATIVO,DATA_NASCIMENTO,LOGRADOURO," +
                    "NUMERO,COMPLEMENTO,BAIRRO,CIDADE,ESTADO,CEP  FROM CLIENTE WHERE ATIVO = 1 ";

                if (!String.IsNullOrEmpty(cliente.NomeCompleto)) 
                {
                    query += " AND NOME_COMPLETO LIKE @nomeCompleto ";
                }
                
                if (cliente.Codigo != 0 && cliente.Codigo != null) {
                    query += " AND CODIGO= @codigo ";
                }
                comandoMysql.CommandText = query;
                comandoMysql.Parameters.AddWithValue("@codigo", cliente.Codigo);
                comandoMysql.Parameters.AddWithValue("@nomeCompleto", "%"+cliente.NomeCompleto+"%");
                comandoMysql.Prepare();

                MySqlDataReader reader = comandoMysql.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();

                while (reader.Read())
                {
                    clientes.Add(AtribuiValoresAoCliente(reader));
                }
                FechaConexao(conn);

                return clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("ClienteDAO.Pesquisar - Error: " + ex.Message);
            }
            return null;
        }

        public void Atualizar(Cliente cliente)
        {
            try
            {
                query = "UPDATE CLIENTE SET  NOME_COMPLETO = @nomeCompleto, " +
                    "EMAIL = @email, TELEFONE = @telefone, DATA_NASCIMENTO = @dataNascimento," +
                    "LOGRADOURO = @logradouro, NUMERO = @numero," +
                    "COMPLEMENTO = @complemento, BAIRRO = @bairro," +
                    "CIDADE = @cidade, ESTADO = @estado," +
                    "CEP = @cep WHERE CODIGO = @codigo;";

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                AdicionaParametrosPreparedStatement(cliente, comandoMysql);

                comandoMysql.Prepare();
                comandoMysql.ExecuteNonQuery();

                MessageBox.Show("Cliente atualizado com sucesso!");
                FechaConexao(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("ClienteDAO.Atualizar - Error: " + ex.Message);
            }
        }



        public List<Cliente> TodosOsClientes()
        {
            try{
                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = conn.CreateCommand();
                query = "SELECT CODIGO,NOME_COMPLETO,EMAIL,TELEFONE,ATIVO,DATA_NASCIMENTO,LOGRADOURO,NUMERO,COMPLEMENTO,BAIRRO,CIDADE,ESTADO,CEP FROM CLIENTE WHERE ATIVO = 1";
                comandoMysql.CommandText = query;
                MySqlDataReader reader = comandoMysql.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                while (reader.Read())
                {
                    clientes.Add(AtribuiValoresAoCliente(reader));
                }
                FechaConexao(conn);

                return clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("ClienteDAO.TodosOsClientes - Error: " + ex.Message);
            }
            return null;
        }

        public Cliente BuscarClientePorCodigo(int codigo)
        {
            try
            {
                query = "SELECT CODIGO,NOME_COMPLETO,EMAIL,TELEFONE,ATIVO,DATA_NASCIMENTO,LOGRADOURO,NUMERO,COMPLEMENTO,BAIRRO,CIDADE,ESTADO,CEP FROM CLIENTE WHERE CODIGO = @codigo";
                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                comandoMysql.Parameters.AddWithValue("@codigo", codigo);
                comandoMysql.CommandText = query;
                comandoMysql.Prepare();
                MySqlDataReader reader = comandoMysql.ExecuteReader();
                Cliente cliente = new Cliente();
                while (reader.Read())
                {
                    cliente = AtribuiValoresAoCliente(reader);
                }
                FechaConexao(conn);

                return cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("ClienteDAO.BuscarClientePorCodigo - Error: " + ex.Message);
            }
            return null;
        }
        public void Inserir(Cliente cliente)
        {
            try
            {
                query = "INSERT INTO CLIENTE (NOME_COMPLETO, EMAIL, TELEFONE,  DATA_NASCIMENTO, LOGRADOURO, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, CEP)" +
                    "VALUES(@nomeCompleto,@email,@telefone,@dataNascimento,@logradouro,@numero,@complemento,@bairro,@cidade,@estado,@cep)";

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                AdicionaParametrosPreparedStatement(cliente, comandoMysql);
                comandoMysql.Prepare();
                comandoMysql.ExecuteNonQuery();

                MessageBox.Show("Cliente incluído com sucesso!");
                FechaConexao(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("ClienteDAO.Inserir - Error: " + ex.Message);
            }
        }

        public void DesativarCliente(Int32 codigo)
        {
            try
            {
                query = "UPDATE CLIENTE SET ATIVO = @ativo  WHERE codigo = @codigo;";

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                comandoMysql.Parameters.AddWithValue("@ativo", 0);
                comandoMysql.Parameters.AddWithValue("@codigo",codigo);
                comandoMysql.Prepare();
                comandoMysql.ExecuteNonQuery();

                MessageBox.Show("Cliente desativado com sucesso!");
                FechaConexao(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("ClienteDAO.DesativarCliente - Error: " + ex.Message);
            }
        }
        public Cliente AtribuiValoresAoCliente(MySqlDataReader reader)
        {
            Cliente cli = new Cliente();
            cli.Codigo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
            cli.NomeCompleto = reader.IsDBNull(1) ? null : reader.GetString(1);
            cli.Email = reader.IsDBNull(2) ? null : reader.GetString(2);
            cli.Telefone = reader.IsDBNull(3) ? null : reader.GetString(3);
            cli.Ativo = reader.GetBoolean(4);
            cli.DataNascimento = reader.IsDBNull(5) ? null : reader.GetString(5);
            cli.Logradouro = reader.IsDBNull(6) ? null : reader.GetString(6);
            cli.Numero = reader.IsDBNull(7) ? null : reader.GetString(7);
            cli.Complemento = reader.IsDBNull(8) ? null : reader.GetString(8);
            cli.Bairro = reader.IsDBNull(9) ? null : reader.GetString(9);
            cli.Cidade = reader.IsDBNull(10) ? null : reader.GetString(10);
            cli.Estado = reader.IsDBNull(11) ? null : reader.GetString(11);
            cli.Cep = reader.IsDBNull(12) ? null : reader.GetString(12);

            return cli;

        }

        private static void AdicionaParametrosPreparedStatement(Cliente cliente, MySqlCommand comandoMysql)
        {
            comandoMysql.Parameters.AddWithValue("@nomeCompleto", cliente.NomeCompleto);
            comandoMysql.Parameters.AddWithValue("@email", cliente.Email);
            comandoMysql.Parameters.AddWithValue("@telefone", cliente.Telefone);
            comandoMysql.Parameters.AddWithValue("@dataNascimento", cliente.DataNascimento);
            comandoMysql.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
            comandoMysql.Parameters.AddWithValue("@numero", cliente.Numero);
            comandoMysql.Parameters.AddWithValue("@complemento", cliente.Complemento);
            comandoMysql.Parameters.AddWithValue("@bairro", cliente.Bairro);
            comandoMysql.Parameters.AddWithValue("@cidade", cliente.Cidade);
            comandoMysql.Parameters.AddWithValue("@estado", cliente.Estado);
            comandoMysql.Parameters.AddWithValue("@cep", cliente.Cep);
            if (cliente.Codigo != 0)
            {
                comandoMysql.Parameters.AddWithValue("@codigo", cliente.Codigo);
            }
        }
        public void FechaConexao(MySqlConnection conn)
        {
            if (conn != null)
            {
                Console.WriteLine("Fechando a conexão!");
                conn.Close();
            }
        }
    }
}

