using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{  

    public class Encuesta
    {
        public string descripcion;

        public DateTime? fechaFinVigencia;

        public List<Pregunta> preguntas;


        public Encuesta()
        {
            this.descripcion = "";
            this.fechaFinVigencia = null;
            this.preguntas = new List<Pregunta>();
        }
        public Encuesta(string descripcion, DateTime fechaFinVigencia,List<Pregunta> preguntas )
        {
            this.descripcion = descripcion;
            this.fechaFinVigencia = fechaFinVigencia;
            this.preguntas = new List<Pregunta>();
        }

        //metodos get y set
        public string _descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public DateTime? _fechaFinVigencia
        {
            get => fechaFinVigencia;
            set => fechaFinVigencia = value;
        }
        public List<Pregunta> _preguntas
        {
            get => preguntas;
            set => preguntas = value;
        }

        //metodo sonTusPreguntas() que recibe una lista de preguntas y devuelve un booleano
        public bool sonTusPreguntas(List<Pregunta> preguntas)
        {
            String pregunta1 = "--> " + preguntas[0]._pregunta;
            String preguntaEncuesta1 = "-->  " + this.preguntas[0]._pregunta;
            String pregunta2 = "--> " + preguntas[1]._pregunta;
            String preguntaEncuesta2 = "--> " + this.preguntas[1]._pregunta;
            MessageBox.Show(pregunta1 + "\n" + preguntaEncuesta1 + "\n" + pregunta2 + "\n" + preguntaEncuesta2);
            bool sonTusPreguntas = this.preguntas.Contains(preguntas[1]) || this.preguntas.Contains(preguntas[0]);
            return sonTusPreguntas;
        }

    } 

}
