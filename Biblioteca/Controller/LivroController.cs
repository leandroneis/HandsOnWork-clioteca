using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.DAO;
using System.Windows.Forms;
using System.Collections;

namespace Biblioteca.Controller
{
    public class LivroController
    {
        private LivroDAO _dao = new LivroDAO();
        
        //Método que chama o dao para desativar o registro do livro com update.
        public void DesativarLivro(String codigo){
            _dao.DesativarLivro(int.Parse(codigo));
        }
        //Método para buscar no banco de dados por codigo,autor ou titulo.
        //Se caso os campos estiverem vazio. Carrega a lista inteira.
        public void BuscarPorCodigoOuAutorOuTituloTelaPesquisar(String codigo, String autor,String titulo, DataGridView dgLivros)
        {
            Livro livro = new Livro();

            if (String.IsNullOrEmpty(codigo) && String.IsNullOrEmpty(autor) && String.IsNullOrEmpty(titulo))
            {
                TodosLivros(dgLivros);
            }
            else
            {
                livro.Codigo = !String.IsNullOrEmpty(codigo) ? int.Parse(codigo) : (int?)null;
                livro.Autor = !String.IsNullOrEmpty(autor) ? autor : null; 
                livro.Titulo = !String.IsNullOrEmpty(titulo) ? titulo : null;
                AtualizaGrid(_dao.Pesquisar(livro), dgLivros);
            }
        }
        //Método que recebe os valores da tela e atualiza.
        public void Atualizar(string codigo,string titulo,string autor,string editora,string categoria,string estoque,string quantidadeDePaginas,string ano,string quantidadeReservada)
        {
            Livro livro = new Livro
            {
                Codigo = int.Parse(codigo),
                Titulo = titulo,
                Autor = autor,
                Editora = editora,
                Categoria = categoria,
                Ativo = true,
                Estoque = int.Parse(estoque),
                QuantidadeDePaginas = String.IsNullOrEmpty(quantidadeDePaginas) ? (int?)null : int.Parse(quantidadeDePaginas),
                Ano = String.IsNullOrEmpty(ano) ? null : ano,
                QuantidadeReservada = int.Parse(quantidadeReservada)                
            };
                    _dao.Atualizar(livro);
        }
        //Método que preenche a DataGridView da tela com os valores da lista recebida.
        public void AtualizaGrid(List<Livro> livros, DataGridView dgLivros)
        {
            dgLivros.Rows.Clear();
            foreach (Livro livro in livros)
            {
                DataGridViewRow row = (DataGridViewRow)dgLivros.Rows[0].Clone();
                row.Cells[0].Value = livro.Codigo;
                row.Cells[1].Value = livro.Titulo;
                row.Cells[2].Value = livro.Autor;
                row.Cells[3].Value = livro.Categoria;
                row.Cells[4].Value = livro.Editora;
                row.Cells[5].Value = livro.Ativo;
                dgLivros.Rows.Add(row);

            }
        }
        //Método para trazer todos os livros. 
        public void TodosLivros(DataGridView dgLivros)
        {
            AtualizaGrid(_dao.TodosOsLivros(), dgLivros);
        }

        //Método para salvar.
        public void Salvar(string titulo, string autor, string editora, string categoria, string estoque, string quantidadeDePaginas, string ano,string quantidadeReservada)
        {
            Livro livro = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                Editora = editora,
                Categoria = categoria,
                Ativo = true,
                Estoque = int.Parse(estoque),
                QuantidadeDePaginas = String.IsNullOrEmpty(quantidadeDePaginas) ? (int?)null : int.Parse(quantidadeDePaginas),
                Ano = String.IsNullOrEmpty(ano) ? null : ano,
                QuantidadeReservada = int.Parse(quantidadeReservada)
            };
            _dao.Inserir(livro);
        }
        //Método responsável por carregar as informações na combobox                    
        public void CarregarComboboxLivros(ComboBox cbLivros)
          {
            cbLivros.SelectedItem = null;
            cbLivros.ValueMember = "codigo";
            cbLivros.DisplayMember = "titulo";
            cbLivros.SelectedValue = "codigo";
            cbLivros.DataSource = _dao.TodosOsLivros();
        }

        //Método busca  o livro por codigo e verifica se possui livros com estoque para o emprestimo.
        //Estoque -> define o valor de livros em estoque.
        //QuantidadeReservada -> define a quantidade de livros que já foram para o emprestimo.

        public bool PossuiLivroDisponivel(string codigo) {
            Livro livro = new Livro();
            livro = _dao.BuscarLivroPorCodigo(int.Parse(codigo));
            int totalLivros = (int)(livro.Estoque - livro.QuantidadeReservada);
            if (totalLivros > 0)
            {
                return true;
            }
            return false;
        }
        //Atualiza a quantidade de livros reservados.
        public void AtualizarQuantidadeReservada(int codigo) {
            _dao.AtualizarQuantidadeReservada(codigo);
        }

        //Preenche os campos da tela para edição com os valores retornados do banco de dados.
        public void PreencherFormularioTelaEdicao(string codigo, TextBox tbCodigo, TextBox tbTituloLivro, TextBox tbAutor, TextBox tbCategoria, TextBox tbEditora, NumericUpDown tbEstoque, TextBox tbAno, NumericUpDown tbNumeroDePaginas, NumericUpDown tbQuantidadeLivrosReservados)
        {
            Livro livro = new Livro();
            livro = _dao.BuscarLivroPorCodigo(int.Parse(codigo));

            if (livro != null)
            {
                tbCodigo.Text = livro.Codigo.ToString();
                tbTituloLivro.Text = livro.Titulo;
                tbAutor.Text = livro.Autor;
                tbCategoria.Text = livro.Categoria;
                tbEditora.Text = livro.Editora;
                tbEstoque.Text = livro.Estoque.ToString();
                tbAno.Text = livro.Ano;
                tbNumeroDePaginas.Text = livro.QuantidadeDePaginas.ToString();
                tbQuantidadeLivrosReservados.Text = livro.QuantidadeReservada.ToString();
            }
        }
    }
}
