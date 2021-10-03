using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Controller;

namespace Biblioteca.View.Emprestimos
{
    public partial class NovoEmprestimo : Form
    {


        private ClienteController _clienteController = new ClienteController();
        private LivroController _livroController = new LivroController();
        private EmprestimoController _emprestimoController = new EmprestimoController();

        public NovoEmprestimo(Main main)
        {
            InitializeComponent();
            ocultaLabelCamposObrigatorios();
            carregarCombos();

        }

        public void PreencherFormularioTelaEdicao(String codigo)
        {
            lbTituloNovoEmprestimo.Text = "Edição de Empréstimo";
            _emprestimoController.PreencherFormularioTelaEdicao(codigo, tbCodigo, cbClientes, cbLivros, dtDataEmprestimo, dtDataDevolucao);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var cliente = cbClientes.SelectedValue.ToString();
            var livro = cbLivros.SelectedValue.ToString();
            var dataEmprestimo = dtDataEmprestimo.Text;
            var dataDevolucao = dtDataDevolucao.Text;

            if (VerificaCamposObrigatoriosPreenchidos(cliente,livro,dataEmprestimo))
            {
               
                if (!String.IsNullOrEmpty(tbCodigo.Text) && !tbCodigo.Text.Equals("0"))
                {
                    _emprestimoController.Atualizar(tbCodigo.Text, cliente, livro,dataEmprestimo, dataDevolucao);
                }
                else
                {
                    if (!_emprestimoController.VerificaQuantidadeEmprestimoPorCliente(cliente))
                    {
                        MessageBox.Show("O Cliente possuí o total de 4 empréstimos no mês!");
                        return;
                    }
                    if (!_livroController.PossuiLivroDisponivel(livro)) {
                        MessageBox.Show("O Livro não possuí estoque suficiente. Escolha outro ou altere no cadastro do livro!");
                        return;
                    }
                    _emprestimoController.Salvar(cliente,livro,dataEmprestimo,dataDevolucao);
                }
                LimparCampos();
            }

        }

        private bool VerificaCamposObrigatoriosPreenchidos(string clientes, string livros, string dataEmprestimo)
        {

            if(!String.IsNullOrEmpty(clientes) && !String.IsNullOrEmpty(livros) && !String.IsNullOrEmpty(dataEmprestimo))
            {
                return true;
            }
            else {
                MostraLabelCamposObrigatorios(clientes, livros, dataEmprestimo);
                return false;
            }
        }

        private void MostraLabelCamposObrigatorios(string clientes, string livros, string dataEmprestimo)
            {

            if (!String.IsNullOrEmpty(clientes))
            {
                lbClienteObrigatorio.Visible = false;
            }
            else {
                lbClienteObrigatorio.Visible = true;
            }
            if (!String.IsNullOrEmpty(livros))
            {
                lbLivroObrigatorio.Visible = false;
            }
            else
            {
                lbLivroObrigatorio.Visible = true;
            }
            if (!String.IsNullOrEmpty(dataEmprestimo)) 
            {
                lbDataEmprestimoObrigatorio.Visible = false;
            }
            else
            {
                lbDataEmprestimoObrigatorio.Visible = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }


        public void LimparCampos() {
            cbClientes.ResetText();
            cbClientes.SelectedText = "  ";
            cbLivros.ResetText();
            cbLivros.SelectedText = " ";
            dtDataEmprestimo.Value = DateTime.Now;
            dtDataDevolucao.Value = DateTime.Now;
            tbCodigo.Text = "";
            lbTituloNovoEmprestimo.Text = "Novo Empréstimo";
            OcultaLabelCamposObrigatorios();
        }

        private void ocultaLabelCamposObrigatorios()
        {
            lbClienteObrigatorio.Visible = false;
            lbLivroObrigatorio.Visible = false;
            lbDataEmprestimoObrigatorio.Visible = false;

        }
        private void carregarCombos()
        {
            _clienteController.CarregarComboboxClientes(this.cbClientes);
            _livroController.CarregarComboboxLivros(this.cbLivros);
            
        }

        private void preencheDataDevolucao(object sender, EventArgs e)
        {
            DateTime dtEmprestimo = Convert.ToDateTime(dtDataEmprestimo.Value.ToString("dd/MM/yyyy"));
            DateTime dtDevolucao = dtEmprestimo.AddDays(30);
            dtDataDevolucao.Value = dtDevolucao;
        }

        private void OcultaLabelCamposObrigatorios()
        {
            lbDataEmprestimoObrigatorio.Visible = false;
            lbClienteObrigatorio.Visible = false;
            lbLivroObrigatorio.Visible = false;
        }
    }
}
