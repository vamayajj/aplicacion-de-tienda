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
            float leche = 3000;
            float huevos = 23000;
            float galletas = 20000;
            float arepas = 12000;

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
                Console.WriteLine("El precio del producto es" + galletas);
                Console.ReadLine();
            }

            if (producto == "Huevos")
            {
                Console.WriteLine("El precio del producto es" + huevos);
                Console.ReadLine();
            }

            if (producto == "Arepas")
            {
                Console.WriteLine("El precio del producto es" + arepas);
                Console.ReadLine();
            }

            if (producto == "Leche")
            {
                Console.WriteLine("El precio del producto es" + leche);
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