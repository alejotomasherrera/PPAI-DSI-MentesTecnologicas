﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{  

    public class Encuesta
    {
        private string descripcion;

        private DateTime? fechaFinVigencia;

        private List<Pregunta> preguntas;


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
            
            bool sonTusPreguntas = this.preguntas.Contains(preguntas[1]) || this.preguntas.Contains(preguntas[0]);
            return sonTusPreguntas;
        }

    } 

}
