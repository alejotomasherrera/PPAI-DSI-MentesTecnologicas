using PPAI_DSI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI
{
    public class IteradorLlamada : IIterador<Llamada>
    {
        private List<Llamada> llamadas;
        private int posicionActual;
        private DateTime fechaDesde;
        private DateTime fechaHasta;

        public IteradorLlamada(List<Llamada> llamadas, DateTime fechaDesde, DateTime fechaHasta)
        {
            this.llamadas = llamadas;
            this.posicionActual = 0;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
        }

        public void primero()
        {
            posicionActual = 0;
        }

        public void siguiente()
        {
            posicionActual++;
        }

        public Llamada actual()
        {
            if (this.cumpleFiltros())
            {
                return llamadas[posicionActual];

            }
            return null;
        }

        public bool haTerminado()
        {
            return posicionActual >= llamadas.Count;
        }

        public bool cumpleFiltros()
        {
            // Implementa la lógica para verificar si la llamada actual cumple con ciertos filtros.
            // Puedes personalizar esta lógica según tus necesidades específicas.
            // Devuelve true si cumple los filtros, de lo contrario, devuelve false.
            if (llamadas[posicionActual].esDePeriodo(this.fechaDesde, this.fechaHasta) && llamadas[posicionActual].tieneRespuestaDeCliente())
            {
                return true;
            }
            return false;

        }
    }
}