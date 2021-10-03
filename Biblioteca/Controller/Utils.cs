using System;
using System.Globalization;
using System.Text.RegularExpressions;


namespace Biblioteca.Controller
{
    public static class Utils
    {
        public static String RemoverCaracteresInvalidos(String valor)
        {

            return Regex.Replace(valor, @"[^\d]", "");
        }


    }
}






