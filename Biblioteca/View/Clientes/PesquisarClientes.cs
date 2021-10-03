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

namespace Biblioteca.View.Clientes
{
    public partial class PesquisarClientes : Form
    {
        private ClienteController _controller = new ClienteController();
        private Form activeForm = null;
        private Main main = null;

        public PesquisarClientes(Main main)
        {
            InitializeComponent();
            ocultaLabelMensagem();
            this.main = main;
        }
       

        private void PesquisarClientes_Load(object sender, EventArgs e)
        {
            atualizarGrid("", "", this.dgClientes);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Equals("0"))
            {
                lbCodigoMsg.Visible = true;
            }
            else
            {
                atualizarGrid(tbCodigo.Text, tbNome.Text, this.dgClientes);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void atualizarGrid(String codigo, String nome, DataGridView dgClientes)
        {
            _controller.BuscarPorCodigoOuNomeTelaPesquisar(codigo, nome, this.dgClientes);
        }
        private void LimparCampos()
        {
            tbCodigo.Value=0;
            tbNome.Clear();
            ocultaLabelMensagem();
            atualizarGrid("", "", dgClientes);
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

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex >= -1 && dgClientes.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    dgClientes.CurrentRow.Selected = true;
                    var codigo = dgClientes.Rows[e.RowIndex].Cells["codigo"].FormattedValue.ToString();
                    NovoCliente telaNovoCliente = new NovoCliente(this.main);
                    telaNovoCliente.PreencherFormularioTelaEdicao(codigo);
                    openChildForm(telaNovoCliente);
                    
                }
            }
        }
    }

}
