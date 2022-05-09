using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_avanzada
{
    class Alumnos<T> : ListaDevPlace<Persona>
    {
        List<Persona> alumnos = new List<Persona>();
        public void AgregarItem(Persona persona)
        {
            alumnos.Add(persona);
        }
        public void BorrarItem(Persona persona)
        {
            if (alumnos.Contains(persona))
            {
                alumnos.Remove(persona);
            }
        }
        public T ObtenerItem(int i)
        {
            return alumnos.ElementAt<Persona>(i);
            
        }
        public int CantidadItem()
        {
            return alumnos.Count;
        }
    }
}
