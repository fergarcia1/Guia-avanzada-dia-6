using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_avanzada
{
    class Pila<T>
    {
        private T[] vec = new T[11];
        private int tope = 0;

        public void Apilar(T x)
        {
            vec[tope] = x;
            tope++;
        }
        public T Desapilar()
        {
            tope--;
            return vec[tope];
        }
        public void Mostrar()
        {
            T[] aux = new T[11];
            int topeOg = tope;
            for(int i = 0; i < topeOg; i++)
            {
                Console.WriteLine(this.vec[tope]);
                aux[i] = Desapilar();          
            }
            for (int i = 0; i < topeOg; i++)
            {
                Apilar(aux[i]);
            }


        }

    }
}
