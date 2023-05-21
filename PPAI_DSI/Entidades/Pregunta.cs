using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Pregunta
    {
        public string pregunta;
        public List<RespuestaPosible> respuestas = new List<RespuestaPosible>();

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
    }
}
