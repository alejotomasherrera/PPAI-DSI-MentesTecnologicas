using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Llamada
    {
        private string DescripcionOperador;
        private string DetalleAccionRequerida;
        private string Duracion;
        private string EncuestaEnviada;
        private string ObservacionAuditor;

        public Llamada(string descripcionOperador, string detalleAccionRequerida, string duracion, string encuestaEnviada, string observacionAuditor)
        {
            DescripcionOperador = descripcionOperador;
            DetalleAccionRequerida = detalleAccionRequerida;
            Duracion = duracion;
            EncuestaEnviada = encuestaEnviada;
            ObservacionAuditor = observacionAuditor;
        }
        public string DescripcionOperadorLlamada
        {
            get => DescripcionOperador;
            set => DescripcionOperador = value;
        }
        public string DetalleAccionRequeridaLlamada
        {
            get => DetalleAccionRequerida;
            set => DetalleAccionRequerida = value;
        }
        public string DuracionLlamada
        {
            get => Duracion;
            set => Duracion = value;
        }
        public string EncuestaEnviadaLlamada
        {
            get => EncuestaEnviada;
            set => EncuestaEnviada = value;
        }
        public string ObservacionAuditorLlamada
        {
            get => ObservacionAuditor;
            set => ObservacionAuditor = value;
        }
    }
}
