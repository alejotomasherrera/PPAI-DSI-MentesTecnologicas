using PPAI_DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI
{
    public class IteradorCambioEstado : IIterador<CambioEstado>
    {

        private List<CambioEstado> cambiosEstado;
        private int posicionActual;
        private DateTime fechaDesde;
        private DateTime fechaHasta;


        public IteradorCambioEstado(List<CambioEstado> cambios, DateTime fechaDesde, DateTime fechaHasta)
        {
            this.cambiosEstado = cambios;
            this.posicionActual = 0;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
        }


        public CambioEstado actual()
        {
            if (this.cumpleFiltros())
            {
                return cambiosEstado[posicionActual];

            }
            return null;
        }

        public bool cumpleFiltros()
        {
            if (cambiosEstado[posicionActual].esEstadoInicial()) { 
                return true;
            }
            return false;
        }

        public bool haTerminado()
        {
            return posicionActual >= cambiosEstado.Count;
        }

        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            posicionActual++;
        }
    }
}
