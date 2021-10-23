using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicialización de las variables

            string producto;

            Console.WriteLine("Los productos disponibles son");
            Console.WriteLine("Paquete de galletas");
            Console.WriteLine("Huevos");
            Console.WriteLine("Arepas");
            Console.WriteLine("Leche");
            Console.WriteLine("Inserte el producto del cual desea saber el precio");

            producto = Console.ReadLine();

            Console.Clear();

            if (producto == "Paquete de galletas")
            {
                Console.WriteLine("El precio del producto es" + 20000);
                Console.ReadLine();
            }

            if (producto == "Huevos")
            {
                Console.WriteLine("El precio del producto es" + 23000);
                Console.ReadLine();
            }

            if (producto == "Arepas")
            {
                Console.WriteLine("El precio del producto es" + 12000);
                Console.ReadLine();
            }

            if (producto == "Leche")
            {
                Console.WriteLine("El precio del producto es" + 3000);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Producto no encontrado, por favor intentelo denuevo");
                Console.WriteLine("Los productos disponibles son");
                Console.WriteLine("Paquete de galletas");
                Console.WriteLine("Huevos");
                Console.WriteLine("Arepas");
                Console.WriteLine("Leche");
                Console.WriteLine("Inserte el producto del cual desea saber el precio");
                Console.ReadLine();
            }


        }

    }

}