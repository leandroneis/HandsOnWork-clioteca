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
    public class EmprestimoController
    {
        private EmprestimoDAO _dao = new EmprestimoDAO();
        private LivroController _livroController = new LivroController();
        private ClienteController _clienteController = new ClienteController();

        public void BuscarPorNomeTelaPesquisar(String clienteCodigo, DataGridView dgEmprestimos)
        {
            Emprestimo emprestimo = new Emprestimo();
            Cliente cliente = new Cliente();

            if (String.IsNullOrEmpty(clienteCodigo) || clienteCodigo.Equals("0"))
            {
                TodosEmprestimos(dgEmprestimos);
            }
            else
            {
                cliente.Codigo = int.Parse(clienteCodigo);
                emprestimo.Cliente = cliente;
               AtualizaGrid(_dao.Pesquisar(emprestimo), dgEmprestimos);
            }
        }

        public void PreencherFormularioTelaEdicao(string codigo, TextBox tbCodigo, ComboBox cbClientes, ComboBox cbLivros, DateTimePicker dtDataEmprestimo, DateTimePicker dtDataDevolucao)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo = _dao.BuscarEmprestimoPorCodigo(int.Parse(codigo));

            if (emprestimo != null)
            {
                cbLivros.SelectedValue = emprestimo.Livro.Codigo;
                cbClientes.SelectedValue = emprestimo.Cliente.Codigo;
                tbCodigo.Text = emprestimo.Codigo.ToString();
                dtDataEmprestimo.Value = emprestimo.DataEmprestimo;
                dtDataDevolucao.Value = emprestimo.DataDevolucao;
            }
        }

        public bool VerificaQuantidadeEmprestimoPorCliente(string cliente)
        {
            int total = _dao.QuantidadeEmprestimoPorCliente(int.Parse(cliente));

            return total < 4 ? true : false;
        }

        public void Salvar(string codigoCliente, string codigoLivro, string dataEmprestimo, string dataDevolucao)
        {
            Emprestimo emprestimo = new Emprestimo();
            
            Cliente cliente = new Cliente();
            cliente.Codigo = int.Parse(codigoCliente);
            
            Livro livro = new Livro();
            livro.Codigo = int.Parse(codigoLivro);

            emprestimo.Cliente = cliente;
            emprestimo.Livro = livro;
            emprestimo.DataEmprestimo = Convert.ToDateTime(dataEmprestimo);
            emprestimo.DataDevolucao = Convert.ToDateTime(dataDevolucao);
            emprestimo.Ativo = true;

            _dao.Inserir(emprestimo);

            _livroController.AtualizarQuantidadeReservada((int)emprestimo.Livro.Codigo);
        }

        public void Atualizar(string codigo, string codigoCliente,string codigoLivro, string dataEmprestimo, string dataDevolucao)
        {
            Cliente cliente = new Cliente(int.Parse(codigoCliente));
            Livro livro = new Livro(int.Parse(codigoLivro));

            Emprestimo emprestimo = new Emprestimo();
            emprestimo.Codigo = int.Parse(codigo);
            emprestimo.DataEmprestimo = DateTime.Parse(dataEmprestimo);
            emprestimo.DataDevolucao = DateTime.Parse(dataDevolucao);
            emprestimo.Ativo = true;
            emprestimo.Cliente = cliente;
            emprestimo.Livro = livro;
       
            _dao.Atualizar(emprestimo);
        }

        public void AtualizaGrid(List<Emprestimo> emprestimos, DataGridView dgEmprestimos)
        {
            dgEmprestimos.Rows.Clear();
            foreach (Emprestimo emprestimo in emprestimos)
            {
                DataGridViewRow row = (DataGridViewRow)dgEmprestimos.Rows[0].Clone();
                row.Cells[0].Value = emprestimo.Codigo;
                row.Cells[1].Value = emprestimo.Cliente.NomeCompleto;
                row.Cells[2].Value = emprestimo.Livro.Titulo;
                row.Cells[3].Value = emprestimo.DataEmprestimo.ToShortDateString();
                row.Cells[4].Value = emprestimo.DataDevolucao.ToShortDateString();
                row.Cells[5].Value = emprestimo.Ativo;
                dgEmprestimos.Rows.Add(row);

            }
        }
        public void TodosEmprestimos(DataGridView dgEmprestimos)
        {
            AtualizaGrid(_dao.TodosOsEmprestimos(), dgEmprestimos);
        }
      
    }
}
