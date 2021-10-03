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
        private void PesquisarLivros_Load(object sender, EventArgs e)
        {
            atualizarGrid("", "", "", this.dgLivros);

        }
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void atualizarGrid(String codigo, String autor, String titulo, DataGridView dgLivros)
        {
            _controller = new LivroController();
            _controller.BuscarPorCodigoOuAutorOuTituloTelaPesquisar(codigo, autor, titulo, dgLivros);
        }
        private void LimparCampos()
        {
            tbCodigo.Value=0;
            tbAutor.Clear();
            tbTitulo.Clear();
            ocultaLabelMensagem();
            atualizarGrid("", "", "", dgLivros);
        }
        private void ocultaLabelMensagem()
        {
            lbCodigoMsg.Visible = false;
        }

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
