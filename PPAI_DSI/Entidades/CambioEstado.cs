using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class CambioEstado
    {
        private DateTime FechaHoraInicio;
        private Estado _Estado;

        public CambioEstado(DateTime fechaHoraInicio, Estado _estado)
        {
            FechaHoraInicio = fechaHoraInicio;
            _Estado = _estado;
        }
        public DateTime FechaHoraInicioCliente
        {
            get => FechaHoraInicio;
            set => FechaHoraInicio  = value;
        }
        public Estado EstadoCambioEstado
        {
            get => _Estado;
            set => _Estado = value;
        }
    }
}
