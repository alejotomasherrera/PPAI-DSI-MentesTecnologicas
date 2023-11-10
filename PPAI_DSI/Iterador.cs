using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI
{
    public interface IIterador<T>
    {
        // Inicializa el iterador para que apunte al primer elemento.
        void primero();

        // Mueve el iterador al siguiente elemento en la colección.
        void siguiente();

        // Obtiene el elemento actual en la posición del iterador.
        T actual();

        // Verifica si el iterador ha llegado al final de la colección.
        bool haTerminado();

        // Verifica si el elemento actual cumple con ciertos filtros.
        bool cumpleFiltros();
    }

}
