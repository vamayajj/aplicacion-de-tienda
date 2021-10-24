using System;
using System.Collections.Generic;
using System.Text;

namespace Clientes

{
    class ClassClientes
    {
        private int idCliente;

        private string _Nombres;

        private string _Apellidos;

        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
