using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_avanzada
{
    public static class MyExtensions
    {
        public static string MitadPrimera(this string cadena)
        {
            return cadena.Substring(0, cadena.Length / 2);
        }
        public static string MitadSegunda(this string cadena)
        {
            return cadena.Substring((cadena.Length / 2),(cadena.Length / 2)+1);
        }

        public static void EsMayor(this Persona p)
        {
            if (p.Edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("No es mayor de edad");
            }
        }
    }
}
