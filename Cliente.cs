﻿using System;

namespace ClientesGeneral
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassClienteVentas Cliente;

            Cliente = new ClassClienteVentas();


            Console.WriteLine("Ingrese el id del cliente");
            Cliente.IdCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los apellidos del cliente");
            Cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese los nombres del cliente");
            Cliente.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese la CC del cliente");
            Cliente.CC = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del cliente");
            Cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el municipio del cliente");
            Cliente.Municipio = Console.ReadLine();
            Console.WriteLine("El cliente tiene crédito? responda con true or false");
            Cliente.EsCredito = bool.Parse(Console.ReadLine());


            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + ", "  + Cliente.Municipio);
            Console.WriteLine(Cliente.CC);
            if(Cliente.EsCredito)
            {
                Console.WriteLine("El cliente tiene credito");
                Cliente.EsCredito = true;
            }
            else
            {
                Console.WriteLine("El cliente no tiene credito");
                Cliente.EsCredito = false;
            }

            Console.ReadKey();
        }
    }
}
