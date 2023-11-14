using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Llamada : Agregado<CambioEstado>
    {
        [Key]
        public int idLlamada { get; set; }

        private string descripcionOperador;
        private string detalleAccionRequerida;
        private int duracion;
        private bool encuestaEnviada;
        private string observacionAuditor;
        private List<CambioEstado>? cambiosDeEstados;
        private Cliente? cliente;
        private List<RespuestaDeCliente>? respuestasDeEncuestas;

        
        public Llamada()
        {
        }

        public Llamada(string descripcionOperador, string detalleAccionRequerida, int duracion, bool encuestaEnviada, string observacionAuditor, List<CambioEstado> cambiosDeEstados, Cliente cliente, List<RespuestaDeCliente> respuestasDeEncuestas)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.cambiosDeEstados = cambiosDeEstados;
            this.cliente = cliente;
            this.respuestasDeEncuestas = respuestasDeEncuestas;
        }

        //metodos get y set de los atributos de la clase
        public string _descripcionOperador { get => descripcionOperador; set => descripcionOperador = value; }
        public string _detalleAccionRequerida { get => detalleAccionRequerida; set => detalleAccionRequerida = value; }
        public int _duracion { get => duracion; set => duracion = value; }
        public bool _encuestaEnviada { get => encuestaEnviada; set => encuestaEnviada = value; }
        public string _observacionAuditor { get => observacionAuditor; set => observacionAuditor = value; }
        public List<CambioEstado> _cambiosDeEstados { get => cambiosDeEstados; set => cambiosDeEstados = value; }
        public Cliente _cliente { get => cliente; set => cliente = value; }
        public List<RespuestaDeCliente>? _respuestasDeEncuestas { get => respuestasDeEncuestas; set => respuestasDeEncuestas = value; }

        
        //metodo llamado tieneRespuestaDeCliente() que verifica si el atributo RespuestasDeEncuestas tiene algun elemento
        public bool tieneRespuestaDeCliente()
        {
            return respuestasDeEncuestas.Count > 0;
        }
        
        
        
        
        //metodo llamado esDePeriodo() que valida si la llamada esta dentro de un periodo dado por 2 parametros date, preguntandole a todos sus "CambioEstado" si el primero esta dentro del periodo y de ese obtiene la fecha y hora
        public bool esDePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            CambioEstado actual;
            IIterador<CambioEstado> iteradorCambioEstado = crearIterador(cambiosDeEstados,fechaDesde,fechaHasta);
            //IteradorCambioEstado iteradorCambioEstado = new IteradorCambioEstado(cambiosDeEstados, fechaDesde, fechaHasta);
            iteradorCambioEstado.primero();
            while (!iteradorCambioEstado.haTerminado()) {
                actual = iteradorCambioEstado.actual();
                if (actual != null) {
                    DateTime fechaHoraPrimerCambioEstado = actual.getFechaHoraInicial();
                    if (fechaHoraPrimerCambioEstado >= fechaDesde && fechaHoraPrimerCambioEstado <= fechaHasta)
                    {
                        return true;
                    }
                }
                iteradorCambioEstado.siguiente();
            }
            return false;









            // primero busca el primer cambio de estado de la llamada asumiendo que estan ordenados
            // Si no estuviesen ordenados "cambioDeEstado.primerCambioDeEstado()"
            //CambioEstado primerCambioEstado = cambiosDeEstados[0];
            // luego obtiene la fecha y hora de ese cambio de estado con el metodo get del cambio de estado
            //DateTime fechaHoraPrimerCambioEstado = primerCambioEstado._fechaHoraInicio;
            // luego compara si la fecha y hora del primer cambio de estado esta dentro del periodo dado por los parametros\
            // si es asi devuelve true, sino false
            //return fechaHoraPrimerCambioEstado >= fechaDesde && fechaHoraPrimerCambioEstado <= fechaHasta;
        }

        public String getNombreCliente()
        {
            return cliente._nombreCompleto;
        }
        public string getEstadoActualString()
        {
            return getEstadoActual().getNombre();
        }


        public Estado getEstadoActual()
        {
            //Si el estado tiene fechaHoraFin null, es el estado actual
            foreach (var i in cambiosDeEstados)
            {
                if (i._fechaHoraFin == null)
                {
                    return i._estado;
                }
            }
            return null;
        }

        public string obtenerDniCliente()
        {
            return cliente._dniCliente.ToString();
        }
        public string obtenerNombreCliente()
        {
            return cliente._nombreCompleto;
        }
        public string obtenerNumeroCelular()
        {
       
            return cliente._numeroCelular;

        }

        //public IteradorCambioEstado crearIterador(List<CambioEstado> cambiosDeEstado,DateTime fechaDesde,DateTime fechaHasta)
        //{
        //    return new IteradorCambioEstado(cambiosDeEstados,fechaDesde,fechaHasta);
        //}


        public List<Pregunta> obtenerPreguntas(List<Pregunta> bdPreguntas)
        {
            // crea una lista de preguntas
            List<Pregunta> preguntas = new List<Pregunta>();

            // recorre todas las respuestas de encuestas de la llamada
            foreach (RespuestaDeCliente respuestaDeCliente in respuestasDeEncuestas)
            {
                // obtiene respuestaPosible de la respuesta del cliente
                RespuestaPosible respuestaElegida = respuestaDeCliente.getRespuestaSeleccionada();

                // obtiene la pregunta de la respuesta posible
                foreach (var pregunta in bdPreguntas)
                {
                    //Dependencia entre respuesta posible y pregunta
                    if (pregunta.esTuRespuesta(respuestaElegida))
                    {
                        preguntas.Add(pregunta);
                    }





                    //if (pregunta._respuestas.Contains(respuestaElegida))
                    //{
                    //    preguntas.Add(pregunta);
                    //}
                }
            }
            
            // devuelve la lista de preguntas
            return preguntas;
        }



        public void MostrarInformacionLlamadas()
        {
            Console.WriteLine($"ID: {idLlamada}");
            Console.WriteLine($"Operador: {_descripcionOperador}");
            Console.WriteLine($"Accion Requerida: {_detalleAccionRequerida}");
            Console.WriteLine($"Duracion: {_duracion}");
            Console.WriteLine($"Encuesta Enviada: {_encuestaEnviada}");
            Console.WriteLine($"Observacion Auditor: {_observacionAuditor}");

            Console.WriteLine("Cambios de Estados:");
            foreach (var cambioEstado in _cambiosDeEstados)
            {
                Console.WriteLine($"   Estado: {cambioEstado._estado._nombre}");
                Console.WriteLine($"   FechaHoraInicio: {cambioEstado._fechaHoraInicio}");
                Console.WriteLine($"   FechaHoraFin: {cambioEstado._fechaHoraFin}");
                Console.WriteLine("   ---");
            }

            Console.WriteLine($"Cliente: {_cliente._nombreCompleto}");
            Console.WriteLine($"Respuestas de Encuestas:");
            foreach (var respuesta in _respuestasDeEncuestas)
            {
                Console.WriteLine($"  Respuesta: {respuesta._respuestaSeleccionada._descripcion}");
            }

            Console.WriteLine("=============================================");
        }

        internal string getDuracion()
        {
            return this._duracion.ToString();
        }

        IIterador<CambioEstado> crearIterador(List<CambioEstado> lista, DateTime fechaDesde, DateTime fechaHasta)
        {
            return new IteradorCambioEstado(lista, fechaDesde, fechaHasta);
        }
    }



}
