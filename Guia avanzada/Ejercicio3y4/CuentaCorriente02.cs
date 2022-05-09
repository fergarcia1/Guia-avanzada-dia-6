using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_avanzada
{
    partial class CuentaCorriente
    {
        public string Moneda { get => moneda; set => moneda = value; }
        public string Propietario { get => Propietario; set => Propietario = value; }
        public double Saldo { get => saldo; set => saldo = value; }

    }
}
