using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio { get; set; }
        private Estado estado { get; set; }
        private DateTime? fechaHoraFin { get; set; }


        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
            // iniciar el atributo FechaHoraFin vacio
            fechaHoraFin = null;

        }
        public DateTime _fechaHoraInicio
        {
            get => fechaHoraInicio;
            set => fechaHoraInicio = value;
        }
        
        public Estado _estado
        {
            get => estado;
            set => estado = value;
        }
        public DateTime? _fechaHoraFin
        {
            get => fechaHoraFin;
            set => fechaHoraFin = value;
        }
    }
}
