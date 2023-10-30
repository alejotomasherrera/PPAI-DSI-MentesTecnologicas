using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidades
{
    public class Cliente
    {
        private int dni;
        private string nombreCompleto;
        private string numeroCelular;

        public Cliente(int dni, string nombreCompleto, string numeroCelular)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.numeroCelular = numeroCelular;
            
        }
        public int _dniCliente
        {
            get => this.dni;
            set => this.dni = value;
        }
        public string _nombreCompleto
        {
            get => this.nombreCompleto;
            set => this.nombreCompleto = value;
        }
        public string _numeroCelular
        {
            get => this.numeroCelular;
            set => this.numeroCelular = value;
        }
    }
}