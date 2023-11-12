using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Pregunta
    {
        [Key]
        public int idPregunta { get; set; }
        private string pregunta;
        private List<RespuestaPosible> respuestas = new List<RespuestaPosible>();

        //Constructor
        public Pregunta()
        {
        }
        public Pregunta(string pregunta, List<RespuestaPosible> respuestas)
        {
            this.pregunta = pregunta;
            this.respuestas = respuestas;
        }
        //metodos get y set
        public string _pregunta
        {
            get => pregunta;
            set => pregunta = value;
        }
        public List<RespuestaPosible> _respuestas
        {
            get => respuestas;
            set => respuestas = value;
        }

        internal bool esTuRespuesta(RespuestaPosible respuestaElegida)
        {
            return this._respuestas.Contains(respuestaElegida);
        }
    }
}
