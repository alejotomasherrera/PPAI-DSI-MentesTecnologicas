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
        //metodo llamado tieneRespuestaDeCliente() que verifica si el atributo RespuestasDeEncuestas tiene algun elemento
        public bool tieneRespuestaDeCliente()
        {
            return RespuestasDeEncuestas.Count > 0;
        }
        //metodo llamado esDePeriodo() que valida si la llamada esta dentro de un periodo dado por 2 parametros date, preguntandole a todos sus "CambioEstado" si el primero esta dentro del periodo y de ese obtiene la fecha y hora
        public bool esDePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            // primero busca el primer cambio de estado de la llamada
            CambioEstado primerCambioEstado = CambiosDeEstados[0];
            // luego obtiene la fecha y hora de ese cambio de estado con el metodo get del cambio de estado
            DateTime fechaHoraPrimerCambioEstado = primerCambioEstado._fechaHoraInicio;
            // luego compara si la fecha y hora del primer cambio de estado esta dentro del periodo dado por los parametros\
            // si es asi devuelve true, sino false
            return fechaHoraPrimerCambioEstado >= fechaDesde && fechaHoraPrimerCambioEstado <= fechaHasta;
        }

        public String getNombreCliente()
        {
            return Cliente.NombreCompletoCliente;
        }

        public Estado getEstadoActual()
        {
            return CambiosDeEstados[CambiosDeEstados.Count - 1]._estado;
        }

        // metodo obtenerPreguntas() que devuelve un arreglo del tipo lista de preguntas
        public List<Pregunta> obtenerPreguntas()
        {
            // crea una lista de preguntas
            List<Pregunta> preguntas = new List<Pregunta>();
            // recorre todas las respuestas de encuestas de la llamada
            foreach (RespuestaDeCliente respuestaDeCliente in RespuestasDeEncuestas)
            {
                // obtiene la pregunta de la respuesta de encuesta
                Pregunta pregunta = respuestaDeCliente.RespuestaSeleccionada.;
                // si la lista de preguntas no contiene la pregunta
                if (!preguntas.Contains(pregunta))
                {
                    // agrega la pregunta a la lista de preguntas
                    preguntas.Add(pregunta);
                }
            }
            // devuelve la lista de preguntas
            return preguntas;
        }

    }


}
