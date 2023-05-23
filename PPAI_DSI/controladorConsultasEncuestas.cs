﻿using PPAI_DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Newtonsoft.Json;


namespace PPAI_DSI
{
    internal class controladorConsultasEncuestas
    {

        private DateTime fechaDesdeLocal;
        private DateTime fechaHastaLocal;
        private List<Llamada> llamadas = new List<Llamada>();
        private List<RespuestaPosible> respuestasPosibles = new List<RespuestaPosible>();
        private List<Encuesta> encuestas = new List<Encuesta>() ;
        private List<Pregunta> preguntas = new List<Pregunta>();
        private List<RespuestaDeCliente> respuestasDeClientes = new List<RespuestaDeCliente>();
        private VentanaConsultarLlamadas pantalla;
        private List<Cliente> clientes = new List<Cliente>();
        private List<Estado> estados =  new List<Estado>();
        private List<CambioEstado> cambiosEstado = new List<CambioEstado>();
        private List<Llamada> llamadasEncontradas = new List<Llamada>();
        private Llamada llamadaElegida;
        private Encuesta encuestaEncontrada;

        //metodo constructor con inicializacion de todos los atributos pasados por parametro y sino pasan parametros que los inicialize vacios segun su tipo de dato
        public controladorConsultasEncuestas(VentanaConsultarLlamadas consultarLlamadas)
        {
            

            this.pantalla = consultarLlamadas;

        }
        public class Root
        {
            public List<Llamada> Llamadas { get; set; }
            public List<Encuesta> Encuestas { get; set; }
        }
        //metodos get y set
        public List<Estado> _estados
        {
            get => estados;
            set => estados = value;
        }
        public List<CambioEstado> _cambiosEstado
        {
            get => cambiosEstado;
            set => cambiosEstado = value;
        }
        public List<Cliente> _clienteList
        {
            get => clientes;
            set => clientes = value;
        }
        public List<RespuestaDeCliente> _respuestasDeClientes
        {
            get => respuestasDeClientes;
            set => respuestasDeClientes = value;
        }
        public List<Pregunta> _preguntas
        {
            get => preguntas;
            set => preguntas = value;
        }
        public List<Encuesta> _encuestas
        {
            get => encuestas;
            set => encuestas = value;
        }
        public List<RespuestaPosible> _respuestasPosibles
        {
            get => respuestasPosibles;
            set => respuestasPosibles = value;
        }
        public List<Llamada> _llamadas
        {
            get => llamadas;
            set => llamadas = value;
        }
        public DateTime _fechaDesdeLocal
        {
            get => fechaDesdeLocal;
            set => fechaDesdeLocal = value;
        }
        public DateTime _fechaHastaLocal
        {
            get => fechaHastaLocal;
            set => fechaHastaLocal = value;
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
            //guarda en los atributos llamadas y encuestas los datos de la base de datos del json BD.json
            string json = File.ReadAllText("C:\\Users\\Alejo\\source\\repos\\PPAI-DSI-MentesTecnologicas\\PPAI_DSI\\BD.json");
            Root root = JsonConvert.DeserializeObject<Root>(json);
            List<Llamada> llamadas = root.Llamadas;
            List<Encuesta> encuestas = root.Encuestas;
            // crea un bucle para recorrer todas las llamadas y verificar si estan respondidas y son de un periodo dado
            // si es asi las agrega a la lista de llamadas encontradas, el metodo para validar si tiene una respuesta es "tieneRespuestaDeCliente"
            foreach (Llamada llamada in llamadas)
            {
                if (llamada.tieneRespuestaDeCliente() && llamada.esDePeriodo(fechaDesde,fechaHasta))
                {
                    llamadasEncontradas.Add(llamada);
                }
            }
            pantalla.pedirSeleccionLlamada(llamadasEncontradas);
        }

        public void llamadaSeleccionada(int indexLlamada)
        {

            mostrarLlamada(llamadasEncontradas[indexLlamada]);
        }
        
        public void mostrarLlamada(Llamada llamadaSeleccionada)
        {
            this.llamadaElegida = llamadaSeleccionada;
            // obtener todos los atributos del cliente de la llamada seleccionada
            string nombreCliente = llamadaElegida._cliente._nombreCompletoCliente;
            string dniCliente = llamadaElegida._cliente._dniCliente.ToString();
            string celularCliente = llamadaElegida._cliente._numeroCelularCliente;
            string duracionLlamada = llamadaElegida._duracion.ToString();
            string estadoActual = llamadaElegida.getEstadoActual()._nombre;

            List<Pregunta> preguntasDeLaLlamada = new List<Pregunta>();
            preguntasDeLaLlamada = llamadaElegida.obtenerPreguntas(preguntas);
            MessageBox.Show(preguntasDeLaLlamada[0]._pregunta);

            //Encuesta encuestaEncontrada = new Encuesta();
            foreach (var encuesta in encuestas)
            {
                if (encuesta.sonTusPreguntas(preguntas))
                {
                    encuestaEncontrada = encuesta;
                }
            }
            List<string> listaPreguntas = new List<string>();
            List<string> listaRespuestas = new List<string>();
            foreach (var pregunta in encuestaEncontrada._preguntas)
            {
                listaPreguntas.Add(pregunta._pregunta);
            }
            foreach (var respuesta in llamadaElegida._respuestasDeEncuestas)
            {
                listaRespuestas.Add(respuesta._respuestaSeleccionada._descripcion);
            }
            if (listaPreguntas.Count == 0)
            {
                MessageBox.Show(encuestaEncontrada._descripcion);

            }
            // enviar a la pantalla los datos del cliente y la llamada con el metodo pedirSeleccionGeneracionCsv()
            pantalla.pedirSeleccionGeneracionCsv(nombreCliente, dniCliente, celularCliente, estadoActual, duracionLlamada,listaPreguntas, listaRespuestas);
  
        }

        public void opcionCsvSeleccionada() { 
            return ;
        }

        /*Genera un csv con el siguiente formato:
        - Encabezado: nombre del cliente, estado actual de la llamada, duración de la llamada.
        - Preguntas: para cada pregunta la descripción de la pregunta, 
        la descripción de la respuesta seleccionada por el cliente. 
        Se incluye una marca para dar cierre a cada pregunta.*/
        public void generarCsv()
        {
            // Datos de ejemplo para escribir en el archivo CSV
            List<string[]> datos = new List<string[]>
            {
                new string[] {  /*llamadaElegida._cliente._nombreCompletoCliente,
                                llamadaElegida.getEstadoActual()._nombre,
                                llamadaElegida._duracion.ToString()*/ },
            };

            // Ruta y nombre de archivo CSV
            string rutaArchivo = "C:\\Users\\Alejo\\source\\repos\\PPAI-DSI-MentesTecnologicas\\PPAI_DSI\\PPAI_DSI.csproj";

            // Separador de campos (puedes cambiarlo a tu preferencia)
            char separador = ',';

            try
            {
                using (StreamWriter escritor = new StreamWriter(rutaArchivo))
                {
                    // Escribir los datos en el archivo CSV
                    foreach (string[] fila in datos)
                    {
                        escritor.WriteLine(string.Join(separador, fila));
                    }
                }

                MessageBox.Show("Archivo CSV generado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el archivo CSV: " + ex.Message);
            }
        }
    }
}
  