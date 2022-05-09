using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_avanzada
{
    partial class CuentaCorriente
    {
        private string moneda;
        private Persona propietario;
        private double saldo;

        public CuentaCorriente(string moneda, Persona propietario, double saldo)
        {
            this.moneda = moneda;
            this.propietario = propietario;
            this.saldo = saldo;
        }
    }
}
