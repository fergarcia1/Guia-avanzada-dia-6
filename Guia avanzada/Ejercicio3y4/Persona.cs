using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_avanzada
{
    partial class Persona
    {
        private string fechaNacimiento;
        private string nombre;

        public Persona(string fechaNacimiento, string nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
        }
    }
}
