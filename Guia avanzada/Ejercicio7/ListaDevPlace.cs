using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_avanzada
{
    public interface ListaDevPlace<T>
    {
        void AgregarItem(T item);
        void BorrarItem(T item);
        T ObtenerItem(int i);
        int CantidadItem();
    }
}
