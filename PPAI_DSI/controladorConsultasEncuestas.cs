using PPAI_DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Text.Json;


namespace PPAI_DSI
{
    internal class controladorConsultasEncuestas
    {

        private DateTime fechaDesdeLocal;
        private DateTime fechaHastaLocal;
        private List<Llamada>? llamadas = new List<Llamada>();
        private List<RespuestaPosible>? respuestasPosibles = new List<RespuestaPosible>();
        private List<Encuesta>? encuestas = new List<Encuesta>() ;
        private List<Pregunta>? preguntas = new List<Pregunta>();
        private List<RespuestaDeCliente>? respuestasDeClientes = new List<RespuestaDeCliente>();
        private VentanaConsultarLlamadas? pantalla;
        private List<Cliente>? clientes = new List<Cliente>();
        private List<Estado>? estados =  new List<Estado>();
        private List<CambioEstado>? cambiosEstado = new List<CambioEstado>();
        private List<Llamada>? llamadasEncontradas = new List<Llamada>();
        private Llamada? llamadaElegida;
        private Encuesta? encuestaEncontrada;
        private List<string>? listaPreguntas;
        private List<string>? listaRespuestas;
        private Mockup? datos;

        
        //metodo constructor con inicializacion de todos los atributos pasados por parametro y sino pasan parametros que los inicialize vacios segun su tipo de dato
        public controladorConsultasEncuestas(VentanaConsultarLlamadas consultarLlamadas)
        {
            datos = new Mockup();
            llamadas = datos._llamadas;
            encuestas = datos._encuestas;
            //Preguntas no deberia estar aqui en teoria
            preguntas = datos._preguntas;
            this.pantalla = consultarLlamadas;

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
            llamadasEncontradas = new List<Llamada>();
            // crea un bucle para recorrer todas las llamadas y verificar si estan respondidas y son de un periodo dado
            // si es asi las agrega a la lista de llamadas encontradas, el metodo para validar si tiene una respuesta es "tieneRespuestaDeCliente"
            foreach (Llamada llamada in llamadas)
            {
                if (llamada.tieneRespuestaDeCliente() && llamada.esDePeriodo(fechaDesde,fechaHasta))
                {
                    llamadasEncontradas.Add(llamada);
                }
            }
            if (llamadasEncontradas.Count == 0)
            {
                MessageBox.Show("No hay llamadas en el período con encuestas respondidas.");
                pantalla.solicitarPeriodoLlamada();
            }
            List<string> dnis = new List<string>();
            List<string> nombres = new List<string>();
            List<string> duraciones = new List<string>();
            foreach (var llamada in llamadasEncontradas)
            {
                dnis.Add(llamada.obtenerDniClinete());
                nombres.Add(llamada.obtenerNombreClinete());
                duraciones.Add(llamada._duracion.ToString());
            }
            //pedir la seleccion una llamada
            pantalla.pedirSeleccionLlamada(dnis,nombres,duraciones);
        }

        public void llamadaSeleccionada(int indexLlamada)
        {
            mostrarLlamada(llamadasEncontradas[indexLlamada]);
        }
        
        public void mostrarLlamada(Llamada llamadaSeleccionada)
        {
            this.llamadaElegida = llamadaSeleccionada;
            // obtener todos los atributos del cliente de la llamada seleccionada
            string nombreCliente = llamadaElegida.obtenerNombreClinete();
            string dniCliente = llamadaElegida.obtenerDniClinete().ToString();
            string celularCliente = llamadaElegida.obtenerNumeroCelular();
            string duracionLlamada = llamadaElegida._duracion.ToString();
            string estadoActual = llamadaElegida.getEstadoActualString();
            

            List<Pregunta> preguntasDeLaLlamada = new List<Pregunta>();

            preguntasDeLaLlamada = llamadaElegida.obtenerPreguntas(datos._preguntas);
            //MessageBox.Show("preguntas de la llamada: " + preguntasDeLaLlamada.Count.ToString());
            //Encuesta encuestaEncontrada = new Encuesta();
            foreach (var encuesta in encuestas)
            {
                if (encuesta.sonTusPreguntas(preguntasDeLaLlamada))
                {
                    //Cuando encuentro la encuesta que tiene las preguntas de la llamada, la guardo en una variable local
                    encuestaEncontrada = encuesta;
                    break;
                }
            }


            //Crear un metodo que contenga la logica de armar la encuesta
            listaPreguntas = new List<string>();
            listaRespuestas = new List<string>();
            //Metodo que arama la encuesta, y recibe como parametro la encuesta encontrada, y las listas de preguntas y respuestas
            armarEncuesta(encuestaEncontrada, listaPreguntas, listaRespuestas);
           
            // enviar a la pantalla los datos del cliente y la llamada con el metodo pedirSeleccionGeneracionCsv()
            pantalla.pedirSeleccionGeneracionCsv(nombreCliente, dniCliente, celularCliente, estadoActual, duracionLlamada,listaPreguntas, listaRespuestas);
  
        }
        //crear un metodo que se llame armarEncuesta(listaPreguntas,listaRespuesta)
        public void armarEncuesta(Encuesta encontrada,List<string> listaPreguntas , List<string> listaRespuesta)
        {
            foreach (var pregunta in encontrada._preguntas)
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
        }

        public void opcionCancelar()
        {
            MessageBox.Show("La consulta ha sido cancelada por el operador");
            pantalla.Close();
        }

        public void opcionCsvSeleccionada() {
            generarCsv();
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
                new string[] {  llamadaElegida.obtenerNombreClinete(),
                                llamadaElegida.getEstadoActualString(),
                                llamadaElegida._duracion.ToString()}
            };
            for (int i=0; i<listaPreguntas.Count;i++)
            {
                datos.Add(new string[] { listaPreguntas[i], listaRespuestas[i] });
            }
              

            // Ruta y nombre de archivo CSV
            string rutaArchivo = "../../../archivo.csv";

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
  