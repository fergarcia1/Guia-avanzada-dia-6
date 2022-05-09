using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_avanzada
{
    partial class Persona
    {
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public void Edad()
        {
            Console.WriteLine("Tengo x años");
        }
    }
}
