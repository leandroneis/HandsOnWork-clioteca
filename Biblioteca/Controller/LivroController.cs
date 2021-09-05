using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.DAO;

namespace Biblioteca.Controller
{
    public class LivroController
    {

        public Livro salvar()
        {
            return null;
        }

        public String excluir(int id)
        {
            return "";
        }

        public Livro editar()
        {
            return null;
        }

        public List<Livro> pesquisar(String valor)
        {
            if (!valor.Equals(""))
            {
                //consulta no banco com os dados passados de cliente....
            }
            else
            {
                //retorna todos....
            }
            return null;
        }

    }
}
