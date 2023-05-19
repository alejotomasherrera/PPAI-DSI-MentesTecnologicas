using PPAI_DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI
{
    internal class controladorConsultasEncuestas
    {
        // declaracion de la lista de llamadas y generar 2  3 llamadas de prueba
        private DateTime fechaDesdeLocal;
        private DateTime fechaHastaLocal;
        private List<Llamada> llamadas;
        private List<RespuestaPosible> respuestasPosibles;
        private List<Encuesta> encuestas ;
        private List<Pregunta> preguntas ;
        private List<RespuestaDeCliente> respuestasDeClientes;
        private VentanaConsultarLlamadas pantalla;
        private List<Cliente> clienteList;
        private List<Estado> Estados;
        private List<CambioEstado> CambiosEstado;

        //metodo constructor con inicializacion de todos los atributos pasados por parametro y sino pasan parametros que los inicialize vacios segun su tipo de dato
        public controladorConsultasEncuestas(VentanaConsultarLlamadas consultarLlamadas)
        {
            // inicializacion de todos los atributos menos consultarLlamadas con arreglos vacios
            llamadas = new List<Llamada>();
            respuestasPosibles = new List<RespuestaPosible>();
            encuestas = new List<Encuesta>();
            preguntas = new List<Pregunta>();
            respuestasDeClientes = new List<RespuestaDeCliente>();
            clienteList = new List<Cliente>();
            Estados = new List<Estado>();
            CambiosEstado = new List<CambioEstado>();

            // inicializacion del atributo consultarLlamadas con el parametro pasado por el constructor
            this.pantalla = consultarLlamadas;
        }


        // metodo llamado "consultarEncuesta()" que le envia un mensaje llamado "solicitarPeriodoLlamada" a la pantalla "ConsultarLlamadas"
        public void consultarEncuesta()
        {
            // como identifico la ventana activa?
            // como le envio el mensaje a la ventana activa?


            // como le envio el mensaje a la ventana "ConsultarLlamadas"? 
            pantalla.solicitarPeriodoLlamada();


        }

        //metodo "fechaInicioYFinSeleccionadas" que recibe 2 parametros de tipo DateTime y los guarda en 2 variables locales e instancia el metodo buscarLLamadasDelPeriodoRespondidas() pasandole las 2 variables locales como parametros
        public void fechaInicioYFinSeleccionadas(DateTime fechaDesde, DateTime fechaHasta)
        {
            // guarda los parametros en variables locales
            fechaDesdeLocal = fechaDesde;
            fechaHastaLocal = fechaHasta;
            // instancia el metodo buscarLLamadasDelPeriodoRespondidas() pasandole las 2 variables locales como parametros
            buscarLLamadasDelPeriodoRespondidas(fechaDesdeLocal, fechaHastaLocal);
        }


        public void buscarLLamadasDelPeriodoRespondidas(DateTime fechaDesde, DateTime fechaHasta)
        {
            // crea un bucle para recorrer todas las llamadas y verificar si estan respondidas y son de un periodo dado
            // si es asi las agrega a la lista de llamadas encontradas, el metodo para validar si tiene una respuesta es "tieneRespuestaDeCliente"
            List<Llamada> llamadasEncontradas = new List<Llamada>();
            foreach (Llamada llamada in llamadas)
            {
                if (llamada.tieneRespuestaDeCliente() && llamada.esDePeriodo(fechaDesde,fechaHasta))
                {
                    llamadasEncontradas.Add(llamada);
                }
            }
            pantalla.pedirSeleccionLlamada(llamadasEncontradas);
        }

        public void llamadaSeleccionada(Llamada llamadaSeleccionada)
        {
            mostrarLlamada(llamadaSeleccionada);
        }
        
        public void mostrarLlamada(Llamada llamadaSeleccionada)
        {
            String nombreCliente = llamadaSeleccionada.getNombreCliente();
            _ = llamadaSeleccionada.Duracion;
            Estado estadoActual = llamadaSeleccionada.getEstadoActual();
        }
    }
}
  