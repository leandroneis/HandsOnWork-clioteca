using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.DAO;


namespace Biblioteca.Controller
{
    public class ClienteController
    {

        public String excluir(int id)
        { return ""; }

        public Cliente editar()
        {  return null; }

        public List<Cliente> pesquisar(String valor)
        {  return null; }

        public void salvar(string nomeCompleto, string email, string telefone, string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string estado, string dataDeNascimento)
        {
            Cliente cliente = new Cliente();
            cliente.NomeCompleto = nomeCompleto;
            cliente.Email = email;
            cliente.Telefone = telefone;
            cliente.Logradouro = logradouro;
            cliente.Numero = numero;
            cliente.Complemento = complemento;
            cliente.Cep = cep;
            cliente.Bairro = bairro;
            cliente.Cidade = cidade;
            cliente.Estado = estado;
            cliente.DataNascimento = Utils.converterStringEmDateTime(dataDeNascimento);

        }
        
    }
}
