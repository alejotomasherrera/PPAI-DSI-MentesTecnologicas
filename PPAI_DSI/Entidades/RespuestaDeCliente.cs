using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class RespuestaDeCliente
    {
        public DateTime FechaEncuesta { get; set; }
        public RespuestaPosible RespuestaSeleccionada { get; set; }

        public RespuestaDeCliente(DateTime fechaEncuesta)
        {
            FechaEncuesta = fechaEncuesta;
        }
    }

}
