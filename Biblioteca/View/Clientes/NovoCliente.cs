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
    public partial class NovoCliente : Form
    {

        private ClienteController _controller;
        public NovoCliente(Main main)
        {
            InitializeComponent();
            OcultaLabelCamposObrigatorios();
            btnDesativar.Visible = false;
            _controller = new ClienteController();
        }

        public void PreencherFormularioTelaEdicao(String codigo) {
            lbTituloNovoCliente.Text = "Edição de Cliente";
            btnDesativar.Visible = true;
            _controller.PreencherFormularioTelaEdicao(codigo, tbCodigo, tbNomeCompleto, tbEmail, mTbTelefone, tbLogradouro, tbNumero, tbComplemento, mTbCep, tbBairro, tbCidade, tbEstado, mTbDataNascimento);
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaCamposObrigatoriosPreenchidos(tbNomeCompleto.Text, mTbTelefone.Text, tbEmail.Text))
            {
                if (!String.IsNullOrEmpty(tbCodigo.Text) && !tbCodigo.Text.Equals("0"))
                {
                    _controller.Atualizar(tbCodigo.Text,tbNomeCompleto.Text, tbEmail.Text, mTbTelefone.Text, tbLogradouro.Text, tbNumero.Text, tbComplemento.Text, mTbCep.Text, tbBairro.Text, tbCidade.Text, tbEstado.Text, mTbDataNascimento.Text);
                }
                else {
                    _controller.Salvar(tbNomeCompleto.Text, tbEmail.Text, mTbTelefone.Text, tbLogradouro.Text, tbNumero.Text, tbComplemento.Text, mTbCep.Text, tbBairro.Text, tbCidade.Text, tbEstado.Text, mTbDataNascimento.Text);
                }
                LimparCampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            tbCodigo.Clear();
            tbNomeCompleto.Clear();
            tbEmail.Clear();
            mTbTelefone.Clear();
            tbLogradouro.Clear();
            tbNumero.Clear();
            tbComplemento.Clear();
            mTbCep.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            mTbDataNascimento.Clear();
            btnDesativar.Visible = false;
            lbTituloNovoCliente.Text = "Novo Cliente";

            OcultaLabelCamposObrigatorios();
        }


        private Boolean VerificaCamposObrigatoriosPreenchidos(String nomeCompleto,String telefone,String email) 
        {
            var telefoneSemMascara = Utils.RemoverCaracteresInvalidos(telefone);
            if (!String.IsNullOrEmpty(nomeCompleto) && !String.IsNullOrEmpty(telefoneSemMascara) && !String.IsNullOrEmpty(email)) {
                return true;
            }
            MostraLabelCamposObrigatorios(nomeCompleto, telefoneSemMascara, email);
            return false;
        }
        private void OcultaLabelCamposObrigatorios() {
            lbNomeObrigatorio.Visible = false;
            lbEmailObrigatorio.Visible = false;
            lbTelefoneObrigatorio.Visible = false;
        }
        private void MostraLabelCamposObrigatorios(String nomeCompleto, String telefone, String email)
        {
            if (String.IsNullOrEmpty(nomeCompleto))
            {
                lbNomeObrigatorio.Visible = true;
            }
            else {
                lbNomeObrigatorio.Visible = false;
            }

            if (String.IsNullOrEmpty(telefone))
            {
                lbTelefoneObrigatorio.Visible = true;
            }
            else {
                lbTelefoneObrigatorio.Visible = false;
            }
            if (String.IsNullOrEmpty(email))
            {
                lbEmailObrigatorio.Visible = true;
            }
            else {
                lbEmailObrigatorio.Visible = false;
            }
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbCodigo.Text) && !tbCodigo.Text.Equals("0")) {
                _controller.DesativarCliente(tbCodigo.Text);

                LimparCampos();
            }
        }
    }
}
