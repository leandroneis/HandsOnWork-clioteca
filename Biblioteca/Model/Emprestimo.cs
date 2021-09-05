using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Emprestimo
    {
        private long codigo;
        private DateTime dataEmprestimo;
        private DateTime dataDevolucao;
        private bool ativo;
        private Cliente cliente;
        private Livro livro;
        

        public Emprestimo() { }

        public Emprestimo(long codigo, DateTime dataEmprestimo, DateTime dataDevolucao, bool ativo, Cliente cliente, Livro livro)
        {
            this.Codigo = codigo;
            this.DataEmprestimo = dataEmprestimo;
            this.DataDevolucao = dataDevolucao;
            this.Ativo = ativo;
            this.Cliente = cliente;
            this.Livro = livro;
        }

        public long Codigo { get => codigo; set => codigo = value; }
        public DateTime DataEmprestimo { get => dataEmprestimo; set => dataEmprestimo = value; }
        public DateTime DataDevolucao { get => dataDevolucao; set => dataDevolucao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Livro Livro { get => livro; set => livro = value; }
    }
}
