using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class ClassClienteVentas : ClassClientes
    {
        private string _CC;

        private string _Direccion;

        private string _Municipio;

        private bool _EsCredito;

        public string CC { get => _CC; set => _CC = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public bool EsCredito { get => _EsCredito; set => _EsCredito = value; }
    }
}
