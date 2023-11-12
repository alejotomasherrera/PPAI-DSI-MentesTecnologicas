using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PPAI_DSI.Entidades
{
    public class Estado {

        [Key]
        public int EstadoId { get; set; }

        [Column("NombreEstado")]
        private string nombre;

        public Estado()
        {
        }
        public Estado(string nombre)
        {
            this.nombre = nombre;
     
        }
        public string _nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }

        internal string getNombre()
        {
            return this.nombre;
        }
    }
}
