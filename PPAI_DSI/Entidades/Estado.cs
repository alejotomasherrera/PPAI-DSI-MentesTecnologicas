using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PPAI_DSI.Entidades
{
    public class Estado { 

        private string Nombre;

        public Estado(string nombre)
        {
            Nombre = nombre;
     
        }
        public string NombreEstado
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
