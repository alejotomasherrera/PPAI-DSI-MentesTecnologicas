using PPAI_DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI
{
    internal interface Agregado<T>

    {
        public IIterador<T> crearIterador(List<T> lista,DateTime fechaDesde,DateTime fechaHasta);
    }
}
 