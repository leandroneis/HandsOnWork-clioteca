using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Biblioteca.Controller
{
    public interface IClienteView
    {
        void SetController(ClientController controller);
        void LimparGrid();
        void AdicionarClienteParaGrid(Cliente cliente);
        void AtualizarGridComClientesAtualizado(Cliente cliente);
        void RemoverClientesDaGrid(Cliente cliente);
        int GetIdClienteSelecionadoGrid();
        void SetClienteSelecionadoGrid(Cliente cliente);

        int Codigo { get; set;}
        string NomeCompleto { get; set; }
        string Telefone { get; set; }
        string Email { get; set; }
        bool Ativo { get; set; }
        DateTime? DataNascimento { get; set; }
        string Logradouro { get; set; }
        string Numero { get; set; }
        string Complemento { get; set; }
        string Bairro { get; set; }
        string Cidade { get; set; }
        string Estado { get; set; }
        string Cep { get; set; }
    }
}
