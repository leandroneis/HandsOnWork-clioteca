using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controller
{
    public static class Utils
    {
        public static DateTime converterStringEmDateTime(String dataStr) {
            var cultureInfo = new CultureInfo("pt-BR");
            var dateTime = new DateTime();
            try
            {
                dateTime = DateTime.Parse(dataStr, cultureInfo, DateTimeStyles.NoCurrentDateDefault);
                Console.WriteLine(dateTime);
            
            }
            catch (FormatException)
            {
                Console.WriteLine("Não foi possível converter a String em data '{0}'", dataStr);
            }
            return dateTime;
        }

    }
}






