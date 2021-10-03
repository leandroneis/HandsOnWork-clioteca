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
    public partial class PesquisarEmprestimo : Form
    {
        private ClienteController _clienteController = new ClienteController();
        private EmprestimoController _emprestimoController = new EmprestimoController();
        private Form activeForm = null;
        private Main main = null;

        public PesquisarEmprestimo(Main main)
        {
            InitializeComponent();
            CarregarCombo();
            this.main = main;
        }
        //Método responsável por carregar a grid ao carregar a página
        private void PesquisarEmprestimo_Load(object sender, EventArgs e)
        {
            AtualizarGrid("", this.dgEmprestimos);
        }

        //Método responsável por pesquisar por cliente
        //Atualiza a grid e depois limpa o combobox.
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid(cbClientes.SelectedValue.ToString(), dgEmprestimos);
            LimparCombobox();
        }

        //Método responsável por limpar os campos da tela
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        //Método para atualizar a grid
        private void AtualizarGrid(String clienteCodigo, DataGridView dgEmprestimo)
        {
            _emprestimoController.BuscarPorNomeTelaPesquisar(clienteCodigo, this.dgEmprestimos);
        }
        //Método para limpar os campos, aonde são setados os campos e recarregado a grid no final.
        private void LimparCampos()
        {
            LimparCombobox();
            AtualizarGrid("", dgEmprestimos);
        }
        //Limpa o combobox Text para um valor default.
        private void LimparCombobox() {
            cbClientes.ResetText();
            cbClientes.SelectedText = "Selecione um Cliente";
        }
        //Metodo responsável para carregar a combobox cliente com sua lista.
        private void CarregarCombo()
        {
            _clienteController.CarregarComboboxClientes(this.cbClientes);
        }
        //Método para instanciar um form filho e e fechar o form aberto. Nesse caso fecha o pesquisar e abre o novo emprestimo.
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            this.main.pnMainTitulo.Visible = false;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.main.pnChildForm.Controls.Add(childForm);
            this.main.pnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Método utilizado para clicar na grid e carregar os dados para a tela de edição.
        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex >= -1 && dgEmprestimos.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    dgEmprestimos.CurrentRow.Selected = true;
                    var codigo = dgEmprestimos.Rows[e.RowIndex].Cells["codigo"].FormattedValue.ToString();
                    NovoEmprestimo telaNovoEmprestimo = new NovoEmprestimo(this.main);
                    telaNovoEmprestimo.PreencherFormularioTelaEdicao(codigo);
                    openChildForm(telaNovoEmprestimo);

                }
            }
        }
    }
}
