using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Formularios.Livros
{
    public partial class NovoLivro : Form
    {
        public NovoLivro()
        {
            InitializeComponent();
            ocultaLabelCamposObrigatorios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            validaCamposObrigatorios();
            //Limpar depois que der ok para o salvar
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public void Limpar() {

            tbTituloLivro.Clear();
            tbAutor.Clear();
            tbAssunto.Clear();
            tbEditora.Clear();
            tbNumeroDePaginas.Clear();
            tbAno.Clear();
            ocultaLabelCamposObrigatorios();

        }

        private void validaCamposObrigatorios()
        {

            if (tbTituloLivro == null || tbTituloLivro.Text == "")
            {
                lbTituloObrigatorio.Visible = true;
            }
            else 
            {
                lbTituloObrigatorio.Visible = false;
            }

            if (tbAutor == null || tbAutor.Text == "")
            {
                lbAutorObrigatorio.Visible = true;
            }
            else
            {
                lbAutorObrigatorio.Visible = false;
            }

            if (tbAssunto == null || tbAssunto.Text == "")
            {
                lbAssuntoObrigatorio.Visible = true;
            }
            else 
            {
                lbAssuntoObrigatorio.Visible = false;
            }

            if (tbEditora == null || tbEditora.Text == "") 
            {
                lbEditoraObrigatorio.Visible = true;
            }
            else
            {
                lbEditoraObrigatorio.Visible = false;
            }
        }

        private void ocultaLabelCamposObrigatorios()
        {
            lbTituloObrigatorio.Visible = false;
            lbAutorObrigatorio.Visible = false;
            lbAssuntoObrigatorio.Visible = false;
            lbEditoraObrigatorio.Visible = false;
            
        }



    }
}
