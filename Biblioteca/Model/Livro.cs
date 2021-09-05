using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Livro
    {
        private long codigo;
        private String titulo; 
        private String autor; 
        private String editora; 
        private String assunto;
        private int quantidadeDePaginas;
        private DateTime ano;
        private bool ativo;


        public Livro(long codigo, String titulo, String autor, String editora, String assunto, int quantidadeDePaginas, DateTime ano, bool ativo)
        {
            this.Codigo = codigo;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editora = editora;
            this.Assunto = assunto;
            this.QuantidadeDePaginas = quantidadeDePaginas;
            this.Ano = ano;
            this.Ativo = ativo;
        }

        public Livro() { }

        public long Codigo { get => codigo; set => codigo = value; }
        public String Titulo { get => titulo; set => titulo = value; }
        public String Autor { get => autor; set => autor = value; }
        public String Editora { get => editora; set => editora = value; }
        public String Assunto { get => assunto; set => assunto = value; }
        public int QuantidadeDePaginas { get => quantidadeDePaginas; set => quantidadeDePaginas = value; }
        public DateTime Ano { get => ano; set => ano = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
