using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI.Entidades;
using Newtonsoft.Json;
using System.ComponentModel;

namespace PPAI_DSI
{
    internal class Mockup
    {
        //lista de llamadas de la clase Llamada
        private List<Llamada> llamadas;
        //lista de clientes de la clase Cliente
        private List<Cliente> clientes;
        //lista de la clase Estado
        private List<Estado> estados;
        //lista de la clase RespuestasPosibles
        private List<RespuestaPosible> respuestasPosibles;
        //lista de la clase Encuesta
        private List<Encuesta> encuestas;
        //lista de la clase Pregunta
        private List<Pregunta> preguntas;
        private List<CambioEstado> cambiosDeEstados;
        private List<RespuestaDeCliente> respuestaDeClientes;

        //metodo contructor
        public Mockup() {
            //levantamos el archivo json
            string json = File.ReadAllText("../../../BDV2.json");
            Root? root = JsonConvert.DeserializeObject<Root>(json);
            //asignamos los valores de las listas
            llamadas = root.Llamadas;
            clientes = root.Clientes;
            estados = root.Estados;
            respuestasPosibles = root.RespuestasPosibles;
            encuestas = root.Encuestas;
            preguntas = root.Preguntas;
            cambiosDeEstados = root.CambiosDeEstados;
            respuestaDeClientes = root.RespuestasDeClientes;

            // cada 3 cambios de estados repetir de nuevo los estados
            //establecer la relacion entre cambio de estado[18] y estado[3]
            int contador = 0;
            for (var i = 0; i < cambiosDeEstados.Count; i++)
            {
                cambiosDeEstados[i]._estado = estados[contador];
                //MessageBox.Show(cambiosDeEstados[i]._estado._nombre);//se asignan correctamente
                contador += 1;
                if (contador == 3)
                {
                    contador = 0;
                }
            }

            // hacer la relacion entre respuestaDeCliente y respuestaPosible(son 12 respuestas posibles)
            
            for (var i = 0; i < respuestasPosibles.Count; i++)
            {
                respuestaDeClientes[i]._respuestaSeleccionada = respuestasPosibles[i];
                //MessageBox.Show(respuestaDeClientes[i]._respuestaSeleccionada._descripcion);//se asignan correctamente
                
            }
            // 1 Lamada, 1 cliente, 3 cambios de estado, 2 respuestas de cliente
            // hacemos la relacion llamada[6],cliente[6], cambio de estado[18] y respuesta de cliente[12]
            contador = 0;
            int contadorRes = 0;
            for (var i = 0; i < 6; i++)
            {
                //pasa 2 veces por cada llamada y pisa al mismo cliente
                llamadas[i]._cliente = clientes[i];
                llamadas[i]._cambiosDeEstados.Add(cambiosDeEstados[contador]);
                //MessageBox.Show(llamadas[i]._cambiosDeEstados[0]._estado._nombre);//Iniciada
                contador++;
                llamadas[i]._cambiosDeEstados.Add(cambiosDeEstados[contador]);
                //MessageBox.Show(llamadas[i]._cambiosDeEstados[1]._estado._nombre);//En proceso
                contador++;
                llamadas[i]._cambiosDeEstados.Add(cambiosDeEstados[contador]);
                //MessageBox.Show(llamadas[i]._cambiosDeEstados[2]._estado._nombre);//Finalizada
                contador++;

                //Son 6 respuestas de clientes
                llamadas[i]._respuestasDeEncuestas.Add(respuestaDeClientes[contadorRes]);
                //MessageBox.Show(llamadas[i]._respuestasDeEncuestas[0]._respuestaSeleccionada._descripcion);
                contadorRes++;
                llamadas[i]._respuestasDeEncuestas.Add(respuestaDeClientes[contadorRes]);
                //MessageBox.Show(llamadas[i]._respuestasDeEncuestas[1]._respuestaSeleccionada._descripcion);
                contadorRes++;

            }
            // 1 pregunta, 2 respuestas posibles
            // hacemos la relacion entre pregunta[6] y respuestaPosible[12]
            int costante = 6;
            
            for (var i = 0; i < 6; i++)
            {
                preguntas[i]._respuestas.Add(respuestasPosibles[i]);
                preguntas[i]._respuestas.Add(respuestasPosibles[i+costante]);
                
            }

            // 1 encuesta, 2 preguntas
            // hacemos la relacion entre encuesta[3] y pregunta[6]
            contador = 0;
            for (var i = 0; i < 3; i++)
            {
                encuestas[i]._preguntas.Add(preguntas[contador]);
                contador++;
                encuestas[i]._preguntas.Add(preguntas[contador]);
                contador++;
             
            }
            /*
             * Sacar el comentario para verificar si carga correctamente los datos
            // Un Messege.show que me muestre cada llamada 
            for (var i = 0; i < 6; i++)
            {
                String llamada = "Llamada: "+i.ToString();
                String nombre = "Nombre Cliente: "+llamadas[i]._cliente._nombreCompleto;
                String nroTelefono = "Nro Telefono: " + llamadas[i]._cliente._numeroCelular;
                String primerEstado = "Primer Estado: " + llamadas[i]._cambiosDeEstados[0]._estado._nombre;
                String segundoEstado = "Segundo Estado: " + llamadas[i]._cambiosDeEstados[1]._estado._nombre;
                String ultimoEstado = "Ultimo Estado:" + llamadas[i]._cambiosDeEstados[2]._estado._nombre;
                String respuesta = "Valor: " + llamadas[i]._respuestasDeEncuestas[0]._respuestaSeleccionada._valor;
                String respuesta2 = "Valor: " + llamadas[i]._respuestasDeEncuestas[1]._respuestaSeleccionada._valor;
                MessageBox.Show(llamada + "\n" + nombre + "\n" + nroTelefono + "\n" + primerEstado + "\n" + segundoEstado + "\n" + ultimoEstado + "\n" + respuesta + "\n" + respuesta2);
            } 

            //Un Messege.show que me muestre cada encuesta
            for (var i = 0; i < 3; i++)
            {
                String encuesta = "Encuesta: " + i.ToString();
                String pregunta1 = "Pregunta 1: " + encuestas[i]._preguntas[0]._pregunta;
                String respuesta11 = "Respuesta 1: " + encuestas[i]._preguntas[0]._respuestas[0]._descripcion;
                String valor11 = "Valor 1: " + encuestas[i]._preguntas[0]._respuestas[0]._valor;
                String respuesta12 = "Respuesta 2: " + encuestas[i]._preguntas[0]._respuestas[1]._descripcion;
                String valor12 = "Valor 2: " + encuestas[i]._preguntas[0]._respuestas[1]._valor;
                String pregunta2 = "Pregunta 2: " + encuestas[i]._preguntas[1]._pregunta;
                String respuesta21 = "Respuesta 2: " + encuestas[i]._preguntas[1]._respuestas[0]._descripcion;
                String valor21 = "Valor 2: " + encuestas[i]._preguntas[1]._respuestas[0]._valor;
                String respuesta22 = "Respuesta 2: " + encuestas[i]._preguntas[1]._respuestas[1]._descripcion;
                String valor22 = "Valor 2: " + encuestas[i]._preguntas[1]._respuestas[1]._valor;
                MessageBox.Show(encuesta + "\n" + pregunta1 + "\n" + respuesta11 + "\n" + valor11 + "\n" + respuesta12 + "\n" + valor12 + "\n" + pregunta2 + "\n" + respuesta21 + "\n" + valor21 + "\n" + respuesta22 + "\n" + valor22);
            }
             */

            

            
        }
        public List<Llamada> _llamadas
        {
            get => llamadas;
            set => llamadas = value;
        }

        public List<Encuesta> _encuestas 
        {
            get => encuestas;
            set => encuestas = value;
        }
        //metodo set y get de la lista de preguntas
        public List<Pregunta> _preguntas
        {
            get => preguntas;
            set => preguntas = value;
        }
        //metodos set y get de los atributos faltantes
        public List<Cliente> _clientes
        {
            get => clientes;
            set => clientes = value;
        }
        public List<Estado> _estados
        {
            get => estados;
            set => estados = value;
        }
        public List<RespuestaPosible> _respuestasPosibles
        {
            get => respuestasPosibles;
            set => respuestasPosibles = value;
        }
        public List<CambioEstado> _cambiosDeEstados
        {
            get => cambiosDeEstados;
            set => cambiosDeEstados = value;
        }
        public List<RespuestaDeCliente> _respuestaDeClientes
        {
            get => respuestaDeClientes;
            set => respuestaDeClientes = value;
        }

    }
}
