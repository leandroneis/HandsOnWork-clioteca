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

namespace Biblioteca.View.Livros
{
    public partial class PesquisarLivros : Form
    {
        private LivroController _controller;
        private Form activeForm = null;
        private Main main = null;

        public PesquisarLivros(Main main)
        {
            InitializeComponent();
            ocultaLabelMensagem();
            this.main = main;
        }
        //Método responsável por carregar a grid ao carregar a página
        private void PesquisarLivros_Load(object sender, EventArgs e)
        {
            atualizarGrid("", "", "", this.dgLivros);

        }

        //Método responsável por pesquisar por codigo ou autor ou titulo
        //Verifica se o código é igual a zero e mostra na tela um label com a mensagem.
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Equals("0"))
            {
                lbCodigoMsg.Visible = true;
            }
            else
            {
                atualizarGrid(tbCodigo.Text, tbAutor.Text, tbTitulo.Text, this.dgLivros);
            }
        }
        //Método responsável por limpar os campos da tela
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        //Método para atualizar a grid
        private void atualizarGrid(String codigo, String autor, String titulo, DataGridView dgLivros)
        {
            _controller = new LivroController();
            _controller.BuscarPorCodigoOuAutorOuTituloTelaPesquisar(codigo, autor, titulo, dgLivros);
        }
        //Método para limpar os campos, aonde são setados os campos e recarregado a grid no final.
        private void LimparCampos()
        {
            tbCodigo.Value=0;
            tbAutor.Clear();
            tbTitulo.Clear();
            ocultaLabelMensagem();
            atualizarGrid("", "", "", dgLivros);
        }
        //Método para ocultar a mensagem de campo obrigatorio da tela.
        private void ocultaLabelMensagem()
        {
            lbCodigoMsg.Visible = false;
        }
        //Método para instanciar um form filho e e fechar o form aberto. Nesse caso fecha o pesquisar e abre o novo cliente.
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
        private void dgLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex >= -1 && dgLivros.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    dgLivros.CurrentRow.Selected = true;
                    var codigo = dgLivros.Rows[e.RowIndex].Cells["codigo"].FormattedValue.ToString();
                    NovoLivro telaNovoLivro = new NovoLivro(this.main);
                    telaNovoLivro.PreencherFormularioTelaEdicao(codigo);
                    openChildForm(telaNovoLivro);

                }
            }
        }
    }
}
