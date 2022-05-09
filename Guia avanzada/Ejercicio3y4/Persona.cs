using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_avanzada
{
    public partial class Persona
    {
        private string fechaNacimiento;
        private string nombre;
        private int edad;

        public Persona(string fechaNacimiento, string nombre,int edad)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
