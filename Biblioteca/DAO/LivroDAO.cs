using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Biblioteca.Model;
using MySql.Data.MySqlClient;

namespace Biblioteca.DAO
{
    public class LivroDAO
    {
        private String query;
        private readonly String MENSAGEM_CONEXAO_FALHOU = "Não foi possível conectar ao banco de dados!";

        public List<Livro> Pesquisar(Livro livro)
        {
            try
            {
                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = conn.CreateCommand();
                query = "SELECT CODIGO,TITULO,AUTOR,EDITORA,CATEGORIA,ATIVO,ESTOQUE,QUANTIDADE_PAGINAS,ANO,QUANTIDADE_RESERVADA FROM LIVRO WHERE ATIVO = 1 ";

                if (!String.IsNullOrEmpty(livro.Titulo)) 
                {
                    query += " AND TITULO like @titulo ";
                }

                if (!String.IsNullOrEmpty(livro.Autor))
                {
                    query += " AND AUTOR like @autor ";
                }

                if (livro.Codigo != 0 && livro.Codigo != null) {
                    query += " AND CODIGO= @codigo ";
                }
                comandoMysql.CommandText = query;
                comandoMysql.Parameters.AddWithValue("@codigo", livro.Codigo);
                comandoMysql.Parameters.AddWithValue("@titulo", "%"+livro.Titulo+"%");
                comandoMysql.Parameters.AddWithValue("@autor", "%" + livro.Autor + "%");
                comandoMysql.Prepare();

                MySqlDataReader reader = comandoMysql.ExecuteReader();
                List<Livro> livros = new List<Livro>();

                while (reader.Read())
                {
                    livros.Add(AtribuiValoresAoLivro(reader));
                }
                FechaConexao(conn);

                return livros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("LivroDAO.Pesquisar - Error: " + ex.Message);
            }
            return null;
        }

        public void Atualizar(Livro livro)
        {
            try
            {
                query = "UPDATE LIVRO  SET  TITULO = @titulo, AUTOR = @autor, EDITORA = @editora, CATEGORIA = @categoria, " +
                    "ESTOQUE=@estoque, QUANTIDADE_PAGINAS = @quantidadePaginas, ANO = @ano, QUANTIDADE_RESERVADA = @quantidadeReservada " +
                    "WHERE CODIGO = @codigo;";

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                AdicionaParametrosPreparedStatement(livro, comandoMysql);

                comandoMysql.Prepare();
                comandoMysql.ExecuteNonQuery();

                MessageBox.Show("Livro atualizado com sucesso!");
                FechaConexao(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("LivroDAO.Atualizar - Error: " + ex.Message);
            }
        }
        
    
        public List<Livro> TodosOsLivros()
        {
            try{
                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = conn.CreateCommand();
                query = "SELECT CODIGO,TITULO,AUTOR,EDITORA,CATEGORIA,ATIVO,ESTOQUE,QUANTIDADE_PAGINAS,ANO,QUANTIDADE_RESERVADA FROM LIVRO WHERE ATIVO = 1 ";
                comandoMysql.CommandText = query;
                MySqlDataReader reader = comandoMysql.ExecuteReader();
                List<Livro> livros = new List<Livro>();
                while (reader.Read())
                {
                    livros.Add(AtribuiValoresAoLivro(reader));
                }
                FechaConexao(conn);

                return livros;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("LivroDAO.TodosOsLivros - Error: " + ex.Message);
            }
            return null;
        }

        public Livro BuscarLivroPorCodigo(int codigo)
        {
            try
            {
                query = "SELECT CODIGO,TITULO,AUTOR,EDITORA,CATEGORIA,ATIVO,ESTOQUE,QUANTIDADE_PAGINAS,ANO,QUANTIDADE_RESERVADA FROM LIVRO WHERE ATIVO = 1 AND CODIGO = @codigo";
                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                comandoMysql.Parameters.AddWithValue("@codigo",codigo);
                comandoMysql.CommandText = query;
                comandoMysql.Prepare();
                MySqlDataReader reader = comandoMysql.ExecuteReader();
                Livro livro = new Livro();
                while (reader.Read())
                {
                    livro = AtribuiValoresAoLivro(reader);
                }
                FechaConexao(conn);

                return livro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("LivroDAO.BuscarLivroPorCodigo - Error: " + ex.Message);
            }
            return null;
        }
        public void Inserir(Livro livro)
        {
            try
            {
                query = "INSERT INTO LIVRO (TITULO,AUTOR,EDITORA,CATEGORIA,ATIVO,ESTOQUE,QUANTIDADE_PAGINAS,ANO,QUANTIDADE_RESERVADA) VALUES (@titulo,@autor,@editora,@categoria,@ativo,@estoque,@quantidadePaginas,@ano,@quantidadeReservada);";

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                AdicionaParametrosPreparedStatement(livro, comandoMysql);
                comandoMysql.Prepare();
                comandoMysql.ExecuteNonQuery();

                MessageBox.Show("Livro incluído com sucesso!");
                FechaConexao(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("LivroDAO.Inserir - Error: " + ex.Message);
            }
        }

        public void DesativarLivro(Int32 codigo)
        {
            try
            {
                query = "UPDATE LIVRO SET ATIVO = @ativo  WHERE codigo = @codigo;";

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                comandoMysql.Parameters.AddWithValue("@ativo", 0);
                comandoMysql.Parameters.AddWithValue("@codigo", codigo);
                comandoMysql.Prepare();
                comandoMysql.ExecuteNonQuery();

                MessageBox.Show("Livro desativado com sucesso!");
                FechaConexao(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("LivroDAO.DesativarLivro - Error: " + ex.Message);
            }
        }
        public Livro AtribuiValoresAoLivro(MySqlDataReader reader)
        {
            Livro li = new Livro();
            li.Codigo = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
            li.Titulo = reader.IsDBNull(1) ? null : reader.GetString(1);
            li.Autor = reader.IsDBNull(2) ? null : reader.GetString(2);
            li.Editora = reader.IsDBNull(3) ? null : reader.GetString(3);
            li.Categoria = reader.IsDBNull(4) ? null : reader.GetString(4);
            li.Ativo = reader.GetBoolean(5);
            li.Estoque= reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6);
            li.QuantidadeDePaginas = reader.IsDBNull(7) ? (int?)null : reader.GetInt32(7);
            li.Ano = reader.IsDBNull(8) ? null : reader.GetString(8);
            li.QuantidadeReservada = reader.IsDBNull(9) ? (int?)null : reader.GetInt32(9);
            


            return li;
        }

        private static void AdicionaParametrosPreparedStatement(Livro livro, MySqlCommand comandoMysql)
        {
            comandoMysql.Parameters.AddWithValue("@titulo", livro.Titulo);
            comandoMysql.Parameters.AddWithValue("@autor", livro.Autor);
            comandoMysql.Parameters.AddWithValue("@editora", livro.Editora);
            comandoMysql.Parameters.AddWithValue("@categoria", livro.Categoria);
            comandoMysql.Parameters.AddWithValue("@ativo", true);
            comandoMysql.Parameters.AddWithValue("@estoque", livro.Estoque);
            comandoMysql.Parameters.AddWithValue("@quantidadePaginas", livro.QuantidadeDePaginas);
            comandoMysql.Parameters.AddWithValue("@ano", livro.Ano);
            comandoMysql.Parameters.AddWithValue("@quantidadeReservada", livro.QuantidadeReservada);

            if (livro.Codigo != 0 && livro.Codigo != null)
            {
                comandoMysql.Parameters.AddWithValue("@codigo", livro.Codigo);
            }
        }

        public void AtualizarQuantidadeReservada(Int32 codigo)
        {
            try
            {
                query = "UPDATE LIVRO SET QUANTIDADE_RESERVADA = QUANTIDADE_RESERVADA+1  WHERE codigo = @codigo;";

                MySqlConnection conn = FabricaDeConexaoDAO.conectar();
                MySqlCommand comandoMysql = new MySqlCommand(query, conn);
                comandoMysql.Parameters.AddWithValue("@codigo", codigo);
                comandoMysql.Prepare();
                comandoMysql.ExecuteNonQuery();
                FechaConexao(conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MENSAGEM_CONEXAO_FALHOU);
                Console.WriteLine("LivroDAO.DesativarLivro - Error: " + ex.Message);
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

