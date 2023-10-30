using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class RespuestaPosible
    {
        private string descripcion;
        private int valor;

        public RespuestaPosible(string descripcion, int valor)
        {
            this.descripcion = descripcion;
            this.valor = valor;
        }
        public string _descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
        public int _valor
        {
            get => valor;
            set => valor = value;
        }
    }
}
