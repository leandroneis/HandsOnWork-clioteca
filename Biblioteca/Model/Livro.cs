using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    public class Livro
    {
        private Nullable<int> codigo;
        private String titulo; 
        private String autor; 
        private String editora; 
        private String categoria;
        private bool ativo;
        private Nullable<int> estoque;
        private Nullable<int> quantidadeDePaginas;
        private String ano;
        private Nullable<int> quantidadeReservada;

        public Livro()
        {
        }

        public Livro(int? codigo) { this.codigo = codigo; }
        
        public Livro(int? codigo, string titulo, string autor, string editora, string categoria, bool ativo, int? estoque, int? quantidadeDePaginas, string ano, int? quantidadeReservada)
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Categoria = categoria;
            Ativo = ativo;
            Estoque = estoque;
            QuantidadeDePaginas = quantidadeDePaginas;
            Ano = ano;
            QuantidadeReservada = quantidadeReservada;
        }

        public int? Codigo { get => codigo; set => codigo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Editora { get => editora; set => editora = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public int? Estoque { get => estoque; set => estoque = value; }
        public int? QuantidadeDePaginas { get => quantidadeDePaginas; set => quantidadeDePaginas = value; }
        public string Ano { get => ano; set => ano = value; }
        public int? QuantidadeReservada { get => quantidadeReservada; set => quantidadeReservada = value; }
    }
}
