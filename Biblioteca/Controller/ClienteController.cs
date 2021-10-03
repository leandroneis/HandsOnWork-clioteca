using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.DAO;
using System.Windows.Forms;
using System.Collections;

namespace Biblioteca.Controller
{
    public class ClienteController
    {
        private ClienteDAO _dao = new ClienteDAO();

        //Desativa um cliente.
        public void DesativarCliente(String codigo)
        {
            _dao.DesativarCliente(int.Parse(codigo));
        }

        //Busca por codigo ou nome do cliente e se caso estiver em branco lista todos os clientes.
        public void BuscarPorCodigoOuNomeTelaPesquisar(String codigo, String nome, DataGridView dtGridClientes)
        {
            Cliente cliente = new Cliente();

            if (String.IsNullOrEmpty(codigo) && String.IsNullOrEmpty(nome))
            {
                TodosClientes(dtGridClientes);
            }
            else
            {
                cliente.Codigo = !String.IsNullOrEmpty(codigo) ? int.Parse(codigo) : (int?)null;
                cliente.NomeCompleto = nome;
                AtualizaGrid(_dao.Pesquisar(cliente), dtGridClientes);
            }
        }

        //Atualiza as informações do banco de dados após preencher as alterações na tela e salvar.
        public void Atualizar(string codigo, string nomeCompleto, string email, string telefone, string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string estado, string dataDeNascimento)
        {
            Cliente cliente = new Cliente
            {
                Codigo = int.Parse(codigo),
                NomeCompleto = nomeCompleto,
                Email = email,
                Telefone = telefone,
                Ativo = true,
                Logradouro = String.IsNullOrEmpty(logradouro) ? null : logradouro,
                Numero = String.IsNullOrEmpty(numero) ? null : numero,
                Complemento = String.IsNullOrEmpty(complemento) ? null : complemento,
                Cep = String.IsNullOrEmpty(Utils.RemoverCaracteresInvalidos(cep)) ? null : Utils.RemoverCaracteresInvalidos(cep),
                Bairro = String.IsNullOrEmpty(bairro) ? null : bairro,
                Cidade = String.IsNullOrEmpty(cidade) ? null : cidade,
                Estado = String.IsNullOrEmpty(estado) ? null : estado,
                DataNascimento = String.IsNullOrEmpty(Utils.RemoverCaracteresInvalidos(dataDeNascimento)) ? null : Utils.RemoverCaracteresInvalidos(dataDeNascimento)
            };

            _dao.Atualizar(cliente);
        }
        //Preenche a data grid view
        public void AtualizaGrid(List<Cliente> clientes, DataGridView dtGridClientes)
        {
            dtGridClientes.Rows.Clear();
            foreach (Cliente cliente in clientes)
            {
                DataGridViewRow row = (DataGridViewRow)dtGridClientes.Rows[0].Clone();
                row.Cells[0].Value = cliente.Codigo;
                row.Cells[1].Value = cliente.NomeCompleto;
                row.Cells[2].Value = cliente.Email;
                row.Cells[3].Value = cliente.Telefone;
                row.Cells[4].Value = cliente.Ativo;
                dtGridClientes.Rows.Add(row);

            }
        }
        //Lista todos os clientes.
        public void TodosClientes(DataGridView dtGridClientes)
        {
            AtualizaGrid(_dao.TodosOsClientes(), dtGridClientes);
        }
        //Salvar as informações da tela.
        public void Salvar(string nomeCompleto, string email, string telefone, string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string estado, string dataDeNascimento)
        {
            
            Cliente cliente = new Cliente
            {
                NomeCompleto = nomeCompleto,
                Email = email,
                Telefone = telefone,
                Ativo = true,
                Logradouro = String.IsNullOrEmpty(logradouro) ? null : logradouro,
                Numero = String.IsNullOrEmpty(numero) ? null : numero,
                Complemento = String.IsNullOrEmpty(complemento) ? null : complemento,
                Cep = String.IsNullOrEmpty(Utils.RemoverCaracteresInvalidos(cep)) ? null : Utils.RemoverCaracteresInvalidos(cep),
                Bairro = String.IsNullOrEmpty(bairro) ? null : bairro,
                Cidade = String.IsNullOrEmpty(cidade) ? null : cidade,
                Estado = String.IsNullOrEmpty(estado) ? null : estado,
                DataNascimento = String.IsNullOrEmpty(Utils.RemoverCaracteresInvalidos(dataDeNascimento)) ? null : Utils.RemoverCaracteresInvalidos(dataDeNascimento)
            };
            _dao.Inserir(cliente);
        }
        //Carrega a combobox com todos os clientes.
        public void CarregarComboboxClientes(ComboBox cbClientes)
        {
            cbClientes.SelectedItem = null;
            cbClientes.ValueMember = "codigo";
            cbClientes.DisplayMember = "nomeCompleto";
            cbClientes.SelectedValue = "codigo";
            cbClientes.SelectedText = "Selecione um Livro";
            cbClientes.DataSource = _dao.TodosOsClientes();
        }

        //Preenche os campos da tela com as informações do banco de dados para edição.
        public void PreencherFormularioTelaEdicao(string codigo, TextBox tbCodigo, TextBox tbNomeCompleto, TextBox tbEmail, MaskedTextBox mTbTelefone, TextBox tbLogradouro, TextBox tbNumero, TextBox tbComplemento, MaskedTextBox mTbCep, TextBox tbBairro, TextBox tbCidade, TextBox tbEstado, MaskedTextBox mTbDataNascimento)
        {
            Cliente cliente = new Cliente();
            cliente = _dao.BuscarClientePorCodigo(int.Parse(codigo));

            if (cliente != null)
            {
                tbCodigo.Text = cliente.Codigo.ToString();
                tbNomeCompleto.Text = cliente.NomeCompleto;
                tbEmail.Text = cliente.Email;
                mTbTelefone.Text = cliente.Telefone;
                tbLogradouro.Text = cliente.Logradouro;
                tbNumero.Text = cliente.Numero;
                tbComplemento.Text = cliente.Complemento;
                mTbCep.Text = cliente.Cep;
                tbBairro.Text = cliente.Bairro;
                tbCidade.Text = cliente.Cidade;
                tbEstado.Text = cliente.Estado;
                mTbDataNascimento.Text = cliente.DataNascimento;

            }
        }
    }
}
