using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class RespuestaPosible
    {
        private string Descripcion;
        private int Valor;

        public RespuestaPosible(string descripcion, int valor)
        {
            Descripcion = descripcion;
            Valor = valor;
        }
        public string DescripcionRespuesta
        {
            get => Descripcion;
            set => Descripcion = value;
        }
        public int ValorRespuesta
        {
            get => Valor;
            set => Valor = value;
        }
    }
}
