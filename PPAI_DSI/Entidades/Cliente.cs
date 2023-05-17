using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Cliente
    {
        private int Dni;
        private string NombreCompleto;
        private string NumeroCelular;

        public Cliente(int dni, string nombreCompleto, string numeroCelular)
        {
            Dni = dni;
            NombreCompleto = nombreCompleto;
            NumeroCelular = numeroCelular;

        }
        public int DniCliente
        {
            get => Dni;
            set => Dni = 0;
        }
        public string NombreCompletoCliente
        {
            get => NombreCompleto;
            set => NombreCompleto = value;
        }
        public string NumeroCelularCliente
        {
            get => NumeroCelular;
            set => NumeroCelular = value;
        }
    }
}