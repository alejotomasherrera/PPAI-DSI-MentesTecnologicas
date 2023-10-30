using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class RespuestaDeCliente
    {
        private DateTime fechaEncuesta;
        private RespuestaPosible respuestaSeleccionada;

        public RespuestaDeCliente(DateTime fechaEncuesta,RespuestaPosible respuestaSeleccionada)
        {
            this.fechaEncuesta = fechaEncuesta;
            this.respuestaSeleccionada = respuestaSeleccionada;
        }
        //metodos get y set
        public DateTime _fechaEncuesta
        {
            get => fechaEncuesta;
            set => fechaEncuesta = value;
        }
        public RespuestaPosible _respuestaSeleccionada
        {
            get => respuestaSeleccionada;
            set => respuestaSeleccionada = value;
        }
    }

}
