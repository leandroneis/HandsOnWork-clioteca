using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Formularios.Emprestimos
{
    public partial class NovoEmprestimo : Form
    {
        public NovoEmprestimo()
        {
            InitializeComponent();
            ocultaLabelCamposObrigatorios();
            teste();
        }

      

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }


        public void LimparCampos() {
            //Verificar como limpar os campos com combobox e datepicker

        }

       

        private void ocultaLabelCamposObrigatorios()
        {
            lbClienteObrigatorio.Visible = false;
            lbLivroObrigatorio.Visible = false;
            lbDataEmprestimoObrigatorio.Visible = false;

        }


        private void teste() {

            System.Object[] ItemObject = new System.Object[10];
            for (int i = 0; i <= 9; i++)
            {
                ItemObject[i] = "Item" + i;
            }
            
            cbCliente.Items.AddRange(ItemObject);

        }


    }
}
