using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class CambioEstado
    {
        [Key]
        public int idCambioEstado { get; set;} 

        private DateTime fechaHoraInicio;
        private Estado estado;
        private DateTime? fechaHoraFin;

        public CambioEstado()
        {
        }
        public CambioEstado(DateTime fechaHoraInicio, Estado estado,DateTime? fechaHoraFin)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
            this.fechaHoraFin = fechaHoraFin;

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

        internal DateTime getFechaHoraInicial()
        {
            return fechaHoraInicio;
        }

        internal bool esEstadoInicial()
        {
            if (estado._nombre == "Iniciada")
            {
                return true;
            }
            return false;
        }
    }
}
