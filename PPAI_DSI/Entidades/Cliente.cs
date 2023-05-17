using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Cliente
    {
        private string Dni;
        private string NombreCompleto;
        private string NumeroCelular;

        public Cliente(string dni, string nombreCompleto, string numeroCelular)
        {
            Dni = dni;
            NombreCompleto = nombreCompleto;
            NumeroCelular = numeroCelular;

        }
        public string DniCliente
        {
            get => Dni;
            set => Dni = value;
        }
        public string NombreCompletoCliente
        {
            get => NombreCompleto;
            set => NombreCompleto = value;
        }
        public string NumeroCelularCliente
        {
            get => NombreCompleto;
            set => NombreCompleto = value;
        }
    }
}