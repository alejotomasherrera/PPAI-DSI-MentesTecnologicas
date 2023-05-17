using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Encuesta
    {
        public string Descripcion { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public List<Pregunta> Preguntas { get; set; } = new List<Pregunta>();

        public Encuesta(string descripcion, DateTime fechaFinVigencia)
        {
            Descripcion = descripcion;
            FechaFinVigencia = fechaFinVigencia;
        }
    } 

}
