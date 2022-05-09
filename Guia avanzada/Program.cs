using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_avanzada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ej1
            Rectangulo rec = new Rectangulo(5.5, 10);
            Console.WriteLine(rec.retornarSuperficie());
            Console.WriteLine(rec.retornarPerimetro());
            Console.ReadKey();

            //Ej2
            Vehiculo auto = new Vehiculo("bueno",60);
            auto.Arrancar();
            auto.Apagar();
            Console.ReadKey();

            //Ej3/4
            Persona persona1 = new Persona("10dejulio", "julio");
            CuentaCorriente cuenta = new CuentaCorriente("peso", persona1, 500.20);

            //Ej5
            Pila<int> pilaInt = new Pila<int>();
            apilarYDesapilar(pilaInt);
            Console.ReadKey();
        }
        static void apilarYDesapilar(Pila<int> pila)
        {
            Console.WriteLine("Apile 10 elementos: ");
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("Elemento " + (i+1) + ": ");
                pila.Apilar(Int32.Parse(Console.ReadLine()));
                i++;
            }
            pila.Mostrar();
            Console.ReadKey();
            while (i > -1)
            {
                pila.Desapilar();
                i++;
            }
            pila.Mostrar();
            Console.ReadKey();
        }
    }
}
