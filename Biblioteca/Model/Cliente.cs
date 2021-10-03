using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model

{
    public class Cliente
    {
        private Nullable<int> codigo;
        private String nomeCompleto;
        private String telefone;
        private String email;
        private bool ativo;
        private String dataNascimento;
        private String logradouro;
        private String numero;
        private String complemento;
        private String bairro;
        private String cidade;
        private String estado;
        private String cep;

        public Cliente() { }

        public Cliente(int codigo) {
            this.codigo = codigo;
        }

        public Cliente(Nullable<int> codigo, String nomeCompleto, String telefone, String email, bool ativo, String dataNascimento, String logradouro, String numero, String complemento, String bairro, String cidade, String estado, String cep)
        {
            this.Codigo = codigo;
            this.NomeCompleto = nomeCompleto;
            this.Telefone = telefone;
            this.Email = email;
            this.Ativo = ativo;
            this.DataNascimento = dataNascimento;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cep = cep;
        }

        public Nullable<int> Codigo { get => codigo; set => codigo = value; }
        public String NomeCompleto { get => nomeCompleto; set => nomeCompleto = value; }
        public String Telefone { get => telefone; set => telefone = value; }
        public String Email { get => email; set => email = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public String Logradouro { get => logradouro; set => logradouro = value; }
        public String Numero { get => numero; set => numero = value; }
        public String Complemento { get => complemento; set => complemento = value; }
        public String Bairro { get => bairro; set => bairro = value; }
        public String Cidade { get => cidade; set => cidade = value; }
        public String Estado { get => estado; set => estado = value; }
        public String Cep { get => cep; set => cep = value; }
        public String DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    }
}
