using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Main : Form
    {
        private Form activeForm = null;
        

        public Main()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing() {
            pnSubMenuClientes.Visible = false;
            pnSubMenuEmprestimos.Visible = false;
            pnSubMenuLivros.Visible = false;
            
        }

        private void hideSubMenu() {
            if(pnSubMenuClientes.Visible == true)
                pnSubMenuClientes.Visible = false;
            if (pnSubMenuEmprestimos.Visible == true)
                pnSubMenuEmprestimos.Visible = false;
            if (pnSubMenuLivros.Visible == true)
                pnSubMenuLivros.Visible = false;
            
        }

        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else {
                subMenu.Visible = false;
            }
        }

        //Cliente
        private void btnCliente_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenuClientes);
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            
            openChildForm(new View.Clientes.NovoCliente(this));
            hideSubMenu();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
         
            openChildForm(new View.Clientes.PesquisarClientes(this));
            hideSubMenu();
        }

        //Emprestimo
        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenuEmprestimos);
        }

        private void btnNovoEmprestimo_Click(object sender, EventArgs e)
        {
          
            openChildForm(new View.Emprestimos.NovoEmprestimo(this));
            hideSubMenu();
        }

        private void btnPesquisarEmprestimos_Click(object sender, EventArgs e)
        {
            openChildForm(new View.Emprestimos.PesquisarEmprestimo(this));
            hideSubMenu();
        }

        //Livros

        private void btnLivro_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubMenuLivros);
        }

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            openChildForm(new View.Livros.NovoLivro(this));
            hideSubMenu();
        }

        private void btnPesquisarLivros_Click(object sender, EventArgs e)
        {
            openChildForm(new View.Livros.PesquisarLivros(this));
            hideSubMenu();
        }

        private void openChildForm(Form childForm) {
            if (activeForm != null)
                activeForm.Close();

            pnMainTitulo.Visible = false;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnChildForm.Controls.Add(childForm);
            pnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        
    }
}
