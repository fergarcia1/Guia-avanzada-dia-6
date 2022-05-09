using System;


namespace Guia_avanzada
{
    public partial class Vehiculo
    {
        private string estadoMotor;
        private int velocidad;

        public Vehiculo(string estadoMotor, int velocidad)
        {
            this.estadoMotor = estadoMotor;
            this.velocidad = velocidad;
        }

        public string EstadoMotor { get => estadoMotor; set => estadoMotor = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
    }
}
