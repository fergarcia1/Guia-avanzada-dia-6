using System;

namespace Guia_avanzada
{
    public partial class Rectangulo
    {
        public double retornarSuperficie()
        {
            return lado1 + lado1 + lado2 + lado2;
        }
        public double retornarPerimetro()
        {
            return lado1 * lado2;
        }

    }
}