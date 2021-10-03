using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca.Model;
using MySql.Data.MySqlClient;

namespace Biblioteca.DAO
{
    public class EmprestimoDAO
    {
        private String query;
        private readonly String MENSAGEM_CONEXAO_FALHOU = "Não foi possível conectar ao banco de dados!";
        
        public List<Emprestimo> Pesquisar(Emprestimo emprestimo)//OLHAR ESSE METODO!!!
        {
            try
            {
                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = conn.CreateCommand();
                query = "SELECT CODIGO,DATA_EMPRESTIMO,DATA_DEVOLUCAO,ATIVO,CLIENTE_CODIGO,LIVRO_CODIGO FROM EMPRESTIMO WHERE ";
                query = "SELECT " +
                  "EMP.CODIGO, " +
                  "EMP.DATA_EMPRESTIMO, " +
                  "EMP.DATA_DEVOLUCAO, " +
                  "EMP.ATIVO, " +
                  "EMP.CLIENTE_CODIGO, " +
                  "CLI.NOME_COMPLETO as NOME_COMPLETO_CLIENTE, " +
                  "EMP.LIVRO_CODIGO, " +
                  "LI.TITULO as TITULO_LIVRO " +
                  "FROM EMPRESTIMO EMP " +
                  "INNER JOIN LIVRO LI ON LI.CODIGO = EMP.LIVRO_CODIGO " +
                  "INNER JOIN CLIENTE CLI ON CLI.CODIGO = EMP.CLIENTE_CODIGO " +
                  "WHERE EMP.ATIVO = 1 ";
                if (emprestimo.Cliente.Codigo != 0 && emprestimo.Cliente.Codigo != null)
                {
                    query += " AND EMP.CLIENTE_CODIGO= @clienteCodigo ";
                }
                comandoMysql.CommandText = query;
                comandoMysql.Parameters.AddWithValue("@clienteCodigo", emprestimo.Cliente.Codigo);
                comandoMysql.Prepare();

                MySqlDataReader reader = comandoMysql.ExecuteReader();
                List<Emprestimo> emprestimos = new List<Emprestimo>();

                while (reader.Read())
                {
                    emprestimos.Add(AtribuiValoresAoEmprestimo(reader));
                }
                FechaConexao(conn);

                return emprestimos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("EmprestimoDAO.Pesquisar - Error: " + ex.Message);
            }
            return null;
        }
        public int QuantidadeEmprestimoPorCliente(int codigo)
        {
            try
            {
                string data = DateTime.Today.ToString("MM");

                query = "SELECT COUNT(CODIGO) AS TOTAL FROM EMPRESTIMO WHERE ATIVO = 1 AND MONTH(DATA_EMPRESTIMO)=@data AND CLIENTE_CODIGO = @codigo";

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                comandoMysql.Parameters.AddWithValue("@codigo", codigo);
                comandoMysql.Parameters.AddWithValue("@data", int.Parse(data));
                comandoMysql.CommandText = query;
                comandoMysql.Prepare();
                MySqlDataReader reader = comandoMysql.ExecuteReader();
                reader.Read();
                int total = reader.GetInt32(0);

                FechaConexao(conn);

                return total;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("EmprestimoDAO.QuantidadeEmprestimoPorCliente - Error: " + ex.Message);
            }
            return 0;
        }

        public Emprestimo BuscarEmprestimoPorCodigo(int codigo)
        {
            try
            {
                query = "SELECT " +
                   "EMP.CODIGO, " +
                   "EMP.DATA_EMPRESTIMO, " +
                   "EMP.DATA_DEVOLUCAO, " +
                   "EMP.ATIVO, " +
                   "EMP.CLIENTE_CODIGO, " +
                   "CLI.NOME_COMPLETO as NOME_COMPLETO_CLIENTE, " +
                   "EMP.LIVRO_CODIGO, " +
                   "LI.TITULO as TITULO_LIVRO " +
                   "FROM EMPRESTIMO EMP " +
                   "INNER JOIN LIVRO LI ON LI.CODIGO = EMP.LIVRO_CODIGO " +
                   "INNER JOIN CLIENTE CLI ON CLI.CODIGO = EMP.CLIENTE_CODIGO " +
                   "WHERE EMP.CODIGO = @codigo";

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                comandoMysql.Parameters.AddWithValue("@codigo", codigo);
                comandoMysql.CommandText = query;
                comandoMysql.Prepare();
                MySqlDataReader reader = comandoMysql.ExecuteReader();
                Emprestimo emprestimo = new Emprestimo();
                while (reader.Read())
                {
                    emprestimo = AtribuiValoresAoEmprestimo(reader);
                }
                FechaConexao(conn);

                return emprestimo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("EmprestimoDAO.BuscarEmprestimoPorCodigo - Error: " + ex.Message);
            }
            return null;
        }

        public void Atualizar(Emprestimo emprestimo)
        {
            try
            {
                query = "UPDATE EMPRESTIMO SET DATA_EMPRESTIMO = @dataEmprestimo, DATA_DEVOLUCAO = @dataDevolucao, " +
                    "CLIENTE_CODIGO = @cliente, LIVRO_CODIGO = @livro WHERE CODIGO = @codigo"; 

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                AdicionaParametrosPreparedStatement(emprestimo, comandoMysql);

                comandoMysql.Prepare();
                comandoMysql.ExecuteNonQuery();

                MessageBox.Show("Emprestimo atualizado com sucesso!");
                FechaConexao(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("EmprestimoDAO.Atualizar - Error: " + ex.Message);
            }
        }
        public List<Emprestimo> TodosOsEmprestimos()
        {
            try
            {
                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = conn.CreateCommand();
                query = "SELECT " +
                    "EMP.CODIGO, " +
                    "EMP.DATA_EMPRESTIMO, " +
                    "EMP.DATA_DEVOLUCAO, " +
                    "EMP.ATIVO, " +
                    "EMP.CLIENTE_CODIGO, " +
                    "CLI.NOME_COMPLETO as NOME_COMPLETO_CLIENTE, " +
                    "EMP.LIVRO_CODIGO, " +
                    "LI.TITULO as TITULO_LIVRO " +
                    "FROM EMPRESTIMO EMP " +
                    "INNER JOIN LIVRO LI ON LI.CODIGO = EMP.LIVRO_CODIGO " +
                    "INNER JOIN CLIENTE CLI ON CLI.CODIGO = EMP.CLIENTE_CODIGO " +
                    "WHERE EMP.ATIVO = 1";
                comandoMysql.CommandText = query;
                MySqlDataReader reader = comandoMysql.ExecuteReader();
                List<Emprestimo> emprestimos = new List<Emprestimo>();
                while (reader.Read())
                {
                    emprestimos.Add(AtribuiValoresAoEmprestimo(reader));
                }
                FechaConexao(conn);

                return emprestimos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("EmprestimoDAO.TodosOsEmprestimos - Error: " + ex.Message);
            }
            return null;
        }
        public void Inserir(Emprestimo emprestimo)
        {
            try
            {
                query = "INSERT INTO EMPRESTIMO (DATA_EMPRESTIMO,DATA_DEVOLUCAO,CLIENTE_CODIGO,LIVRO_CODIGO) VALUES (@dataEmprestimo,@dataDevolucao,@cliente,@livro)";

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                AdicionaParametrosPreparedStatement(emprestimo, comandoMysql);
                comandoMysql.Prepare();
                comandoMysql.ExecuteNonQuery();

                MessageBox.Show("Emprestimo incluído com sucesso!");
                FechaConexao(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("EmprestimoDAO.Inserir - Error: " + ex.Message);
            }
        }
               
        public Emprestimo AtribuiValoresAoEmprestimo(MySqlDataReader reader)
        {
            Emprestimo emprestimo = new Emprestimo();
            Livro livro = new Livro();
            Cliente cliente = new Cliente();
            emprestimo.Codigo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
            emprestimo.DataEmprestimo = reader.GetDateTime(1);
            emprestimo.DataDevolucao =  reader.GetDateTime(2);
            emprestimo.Ativo = reader.GetBoolean(3);
            cliente.Codigo = reader.GetInt32(4);
            cliente.NomeCompleto = reader.GetString(5);
            livro.Codigo = reader.GetInt32(6);
            livro.Titulo = reader.GetString(7);
            emprestimo.Cliente = cliente;
            emprestimo.Livro = livro;
            
            return emprestimo;
          }
        
        private static void AdicionaParametrosPreparedStatement(Emprestimo emprestimo, MySqlCommand comandoMysql)
        {
            comandoMysql.Parameters.AddWithValue("@dataEmprestimo", emprestimo.DataEmprestimo);
            comandoMysql.Parameters.AddWithValue("@dataDevolucao", emprestimo.DataDevolucao);
            comandoMysql.Parameters.AddWithValue("@cliente", emprestimo.Cliente.Codigo);
            comandoMysql.Parameters.AddWithValue("@livro", emprestimo.Livro.Codigo);
            if (emprestimo.Codigo != 0)
            {
                comandoMysql.Parameters.AddWithValue("@codigo", emprestimo.Codigo);
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

