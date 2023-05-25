using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    internal class Root
    {
        public List<Llamada>? Llamadas { get; set; }
        public List<Encuesta>? Encuestas { get; set; }
        public List<Pregunta>? Preguntas { get; set; }
        public List<RespuestaPosible>? RespuestasPosibles { get; set; }
        public List<Cliente>? Clientes { get; set; }
        public List<Estado>? Estados { get; set; }
        public List<CambioEstado>? CambiosDeEstados { get; set; }
        public List<RespuestaDeCliente>? RespuestasDeClientes { get; set; }
    }
}
