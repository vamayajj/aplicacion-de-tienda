
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTienda
{
    class ClassCliente
    {
        private int idCliente;

        private string _Nombres;

        private string _Apellidos;

        private string _CC;

        private string _Direccion;

        private string _Municipio;

        private bool _EsCredito;

        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string CC { get => _CC; set => _CC = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public bool EsCredito { get => _EsCredito; set => _EsCredito = value; }
    }
}

