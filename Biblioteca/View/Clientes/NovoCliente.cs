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

namespace Biblioteca.Formularios.Clientes
{
    public partial class NovoCliente : Form
    {

        private ClienteController controller;
        public NovoCliente()
        {
            InitializeComponent();
            ocultaLabelCamposObrigatorios();
            this.controller = new ClienteController();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(verificaCamposObrigatoriosPreenchidos(tbNomeCompleto.Text, mtbTelefone.Text, tbEmail.Text)){
                controller.salvar(tbNomeCompleto.Text, tbEmail.Text, mtbTelefone.Text, tbLogradouro.Text, tbNumero.Text, tbComplemento.Text, mTbCep.Text, tbBairro.Text, tbCidade.Text, tbEstado.Text, dtDataDeNascimento.Text);
            }
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            tbNomeCompleto.Clear();
            tbEmail.Clear();
            mtbTelefone.Clear();
            tbLogradouro.Clear();
            tbNumero.Clear();
            tbComplemento.Clear();
            mTbCep.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            tbEstado.Clear();
            //VerificarDataDeNascimento
            ocultaLabelCamposObrigatorios();
        }


        private Boolean verificaCamposObrigatoriosPreenchidos(String nomeCompleto,String telefone,String email) 
        {
            if (!nomeCompleto.Equals("") && !telefone.Equals("") && !email.Equals("")) {
                return true;
            }

            return false;


        }
        private void ocultaLabelCamposObrigatorios() {
            lbNomeObrigatorio.Visible = false;
            lbEmailObrigatorio.Visible = false;
            lbTelefoneObrigatorio.Visible = false;
        }
    }
}
