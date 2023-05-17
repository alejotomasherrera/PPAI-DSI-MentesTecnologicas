using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Llamada
    {
        public string DescripcionOperador { get; set; }
        public string DetalleAccionRequerida { get; set; }
        public int Duracion { get; set; }
        public string EncuestaEnviada { get; set; }
        public string ObservacionAuditor { get; set; }
        public List<CambioEstado> CambiosDeEstados { get; set; }
        public Cliente Cliente { get; set; }
        public List<RespuestaDeCliente> RespuestasDeEncuestas { get; set; }

        public Llamada(string descripcionOperador, string detalleAccionRequerida, int duracion, string encuestaEnviada, string observacionAuditor, Cliente clienteLlamada)
        {
            DescripcionOperador = descripcionOperador;
            DetalleAccionRequerida = detalleAccionRequerida;
            Duracion = duracion;
            EncuestaEnviada = encuestaEnviada;
            ObservacionAuditor = observacionAuditor;
            CambiosDeEstados = new List<CambioEstado>();
            Cliente = clienteLlamada;
            RespuestasDeEncuestas = new List<RespuestaDeCliente>();
        }
    }

}
