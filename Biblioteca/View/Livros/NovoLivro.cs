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
    public partial class NovoLivro : Form
    {
        private LivroController _controller;

        public NovoLivro(Main main)
        {
            InitializeComponent();
            OcultaLabelCamposObrigatorios();
            btnDesativar.Visible = false;
            _controller = new LivroController();
        }
        //Envia para o controller as informações para receber os dados nos campos da tela.
        //Verifica se o livro esta disponivel.
        public void PreencherFormularioTelaEdicao(String codigo)
        {
            lbTituloNovoLivro.Text = "Edição do Livro";
            btnDesativar.Visible = true;
            _controller.PreencherFormularioTelaEdicao(codigo, tbCodigo, tbTituloLivro, tbAutor, tbCategoria, tbEditora,tbEstoque, tbAno, tbNumeroDePaginas,tbQuantidadeLivrosReservados);

            if (!_controller.PossuiLivroDisponivel(codigo))
            {
                tbQuantidadeLivrosReservados.Visible = true;
                lbQuantidadeLivrosReservados.Visible = true;
            }
        }
        //O Salvar funciona tanto para atualizar quanto para novo registro.
        //Faz algumas validações como verificar se os campos obrigatórios estão preenchidos.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (VerificaCamposObrigatoriosPreenchidos(tbTituloLivro.Text, tbAutor.Text, tbCategoria.Text, tbEditora.Text, tbEstoque.Text))
            {
                if (!String.IsNullOrEmpty(tbCodigo.Text) && !tbCodigo.Text.Equals("0") && !String.IsNullOrEmpty(tbEstoque.Text) && !tbEstoque.Text.Equals("0"))
                {
                    _controller.Atualizar(tbCodigo.Text, tbTituloLivro.Text, tbAutor.Text, tbCategoria.Text, tbEditora.Text, tbEstoque.Text, tbNumeroDePaginas.Text, tbAno.Text,tbQuantidadeLivrosReservados.Text);
                }
                else
                {
                    _controller.Salvar(tbTituloLivro.Text, tbAutor.Text, tbEditora.Text, tbCategoria.Text, tbEstoque.Text, tbNumeroDePaginas.Text,tbAno.Text, tbQuantidadeLivrosReservados.Text);
                }
                LimparCampos();
            }
        }
        //Limpa os campos da tela.
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        //Onde é setado os campos para serem limpos.
        private void LimparCampos()
        {
            tbCodigo.Clear();
            tbTituloLivro.Clear();
            tbAutor.Clear();
            tbCategoria.Clear();
            tbEditora.Clear();
            tbNumeroDePaginas.Value=0;
            tbEstoque.Value = 0;
            tbAno.Clear();
            btnDesativar.Visible = false;
            lbTituloNovoLivro.Text = "Novo Livro";
            tbQuantidadeLivrosReservados.Visible = false;
            lbQuantidadeLivrosReservados.Visible = false;

            OcultaLabelCamposObrigatorios();
        }

        //Verifica se os campos obrigatorios estao preenchidos.
        private Boolean VerificaCamposObrigatoriosPreenchidos(String titulo, String autor, String categoria,String editora, String estoque)
        {
            if (!String.IsNullOrEmpty(titulo) && !String.IsNullOrEmpty(autor) && !String.IsNullOrEmpty(categoria) && !String.IsNullOrEmpty(editora)&& !String.IsNullOrEmpty(estoque))
            {
                return true;
            }
            MostraLabelCamposObrigatorios(titulo, autor, categoria, editora,estoque);
            return false;
        }
        //Oculta label com msg de campos obrigatorios
        private void OcultaLabelCamposObrigatorios()
        {
            lbTituloObrigatorio.Visible = false;
            lbAutorObrigatorio.Visible = false;
            lbCategoriaObrigatorio.Visible = false;
            lbEditoraObrigatorio.Visible = false;
            lbEstoqueObrigatorio.Visible = false;
        }
        //Verifica para mostrar a label ou remover de campo obrigatorio.
        private void MostraLabelCamposObrigatorios(String titulo, String autor, String categoria, String editora, String estoque)
        {
            if (String.IsNullOrEmpty(titulo))
            {
                lbTituloObrigatorio.Visible = true;
            }
            else
            {
                lbTituloObrigatorio.Visible = false;
            }

            if (String.IsNullOrEmpty(autor))
            {
                lbAutorObrigatorio.Visible = true;
            }
            else
            {
                lbAutorObrigatorio.Visible = false;
            }
            if (String.IsNullOrEmpty(categoria))
            {
                lbCategoriaObrigatorio.Visible = true;
            }
            else
            {
                lbCategoriaObrigatorio.Visible = false;
            }
            if (String.IsNullOrEmpty(editora))
            {
                lbEditoraObrigatorio.Visible = true;
            }
            else
            {
                lbEditoraObrigatorio.Visible = false;
            }
            if (String.IsNullOrEmpty(estoque) || estoque.Equals("0"))
            {
                lbEstoqueObrigatorio.Visible = true;
            }
            else
            {
                lbEstoqueObrigatorio.Visible = false;
            }
        }
        //Desativa um registro.
        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbCodigo.Text) && !tbCodigo.Text.Equals("0"))
            {
                _controller.DesativarLivro(tbCodigo.Text);

                LimparCampos();
            }
        }

       
    }
}
