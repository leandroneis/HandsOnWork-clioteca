using System;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Biblioteca.Controller
{
    public static class Utils
    {   //Método utilizado para remover caracteres inválidos dos valores.
        //Campos que não são obrigatórios e possuem mascaras por exemplo.
        public static String RemoverCaracteresInvalidos(String valor){
            return Regex.Replace(valor, @"[^\d]", "");
        }
    }
}






