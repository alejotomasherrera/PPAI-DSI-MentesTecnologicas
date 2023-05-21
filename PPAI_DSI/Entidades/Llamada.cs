﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Llamada
    {
        public string descripcionOperador;
        public string detalleAccionRequerida;
        public int duracion;
        public bool encuestaEnviada;
        public string observacionAuditor;
        public List<CambioEstado> cambiosDeEstados;
        public Cliente cliente;
        public List<RespuestaDeCliente> respuestasDeEncuestas;

        public Llamada(string descripcionOperador, string detalleAccionRequerida, int duracion, bool encuestaEnviada, string observacionAuditor, Cliente clienteLlamada)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.cliente = clienteLlamada;
            this.cambiosDeEstados = new List<CambioEstado>();
            this.respuestasDeEncuestas = new List<RespuestaDeCliente>();

        }
        //metodos get y set de los atributos de la clase
        public string _descripcionOperador { get => descripcionOperador; set => descripcionOperador = value; }
        public string _detalleAccionRequerida { get => detalleAccionRequerida; set => detalleAccionRequerida = value; }
        public int _duracion { get => duracion; set => duracion = value; }
        public bool _encuestaEnviada { get => encuestaEnviada; set => encuestaEnviada = value; }
        public string _observacionAuditor { get => observacionAuditor; set => observacionAuditor = value; }
        public List<CambioEstado> _cambiosDeEstados { get => cambiosDeEstados; set => cambiosDeEstados = value; }
        public Cliente _cliente { get => cliente; set => cliente = value; }
        public List<RespuestaDeCliente> _respuestasDeEncuestas { get => respuestasDeEncuestas; set => respuestasDeEncuestas = value; }




        //metodo llamado tieneRespuestaDeCliente() que verifica si el atributo RespuestasDeEncuestas tiene algun elemento
        public bool tieneRespuestaDeCliente()
        {
            return respuestasDeEncuestas.Count > 0;
        }
        //metodo llamado esDePeriodo() que valida si la llamada esta dentro de un periodo dado por 2 parametros date, preguntandole a todos sus "CambioEstado" si el primero esta dentro del periodo y de ese obtiene la fecha y hora
        public bool esDePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            // primero busca el primer cambio de estado de la llamada
            CambioEstado primerCambioEstado = cambiosDeEstados[0];
            // luego obtiene la fecha y hora de ese cambio de estado con el metodo get del cambio de estado
            DateTime fechaHoraPrimerCambioEstado = primerCambioEstado._fechaHoraInicio;
            // luego compara si la fecha y hora del primer cambio de estado esta dentro del periodo dado por los parametros\
            // si es asi devuelve true, sino false
            return fechaHoraPrimerCambioEstado >= fechaDesde && fechaHoraPrimerCambioEstado <= fechaHasta;
        }

        public String getNombreCliente()
        {
            return cliente._nombreCompletoCliente;
        }

        public Estado getEstadoActual()
        {
            foreach (var i in cambiosDeEstados)
            {
                if (i._fechaHoraFin == null)
                {
                    return i._estado;
                }
            }
            return null;
        }

        // metodo obtenerPreguntas() que devuelve un arreglo del tipo lista de preguntas
        public List<Pregunta> obtenerPreguntas(List<Pregunta> bdPreguntas)
        {
            // crea una lista de preguntas
            List<Pregunta> preguntas = new List<Pregunta>();
            // recorre todas las respuestas de encuestas de la llamada
            foreach (RespuestaDeCliente respuestaDeCliente in respuestasDeEncuestas)
            {
                // obtiene respuestaPosible de la respuesta de cliente
                RespuestaPosible respuestaElegida = respuestaDeCliente._respuestaSeleccionada;

                // obtiene la pregunta de la respuesta posible
                foreach (var pregunta in bdPreguntas)
                {
                    if (pregunta._respuestas.Contains(respuestaElegida))
                    {
                        preguntas.Add(pregunta);
                    }
                }

            }
            // devuelve la lista de preguntas
            return preguntas;
        }

    }


}
