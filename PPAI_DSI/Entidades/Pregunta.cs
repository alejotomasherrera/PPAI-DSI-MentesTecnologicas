using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Pregunta
    {
        public string PreguntaLlamada { get; set; }
        public List<RespuestaPosible> Respuestas { get; set; } = new List<RespuestaPosible>();

        public Pregunta(string pregunta)
        {
            PreguntaLlamada = pregunta;
        }
    }
}
