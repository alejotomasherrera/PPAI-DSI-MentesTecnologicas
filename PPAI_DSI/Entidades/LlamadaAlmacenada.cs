using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class LlamadaAlmacenada
    {
        private string Dni;
        private string NombreCompleto;
        private string NumeroCelular;
        private string Duracion;
        private string EncuestaEnviada;

        public LlamadaAlmacenada(string dni, string nombreCompleto, string duracion, string nroCelular, string encuestaEnviada)
        {
            Dni = dni;
            NombreCompleto = nombreCompleto;
            NumeroCelular = nroCelular;
            Duracion = duracion;
            EncuestaEnviada = encuestaEnviada;

        }
        public string DniLlamadaAlmacenada
        {
            get => Dni;
            set => Dni = value;
        }
        public string NombreCompletoLlamadaAlmacenada
        {
            get => NombreCompleto;
            set => NombreCompleto = value;
        }
        public string NumeroCelularLlamadaAlmacenada
        {
            get => NumeroCelular;
            set => NumeroCelular = value;
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
    }
}
