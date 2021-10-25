using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace AppTienda
{
    class Principal
    {
        public void start()
        {


            Title = "Tienda de Don chucho";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = @"

 ________  ______  ________  __    __  _______    ______         _______   ________        _______    ______   __    __         ______   __    __  __    __   ______   __    __   ______  
/        |/      |/        |/  \  /  |/       \  /      \       /       \ /        |      /       \  /      \ /  \  /  |       /      \ /  |  /  |/  |  /  | /      \ /  |  /  | /      \ 
$$$$$$$$/ $$$$$$/ $$$$$$$$/ $$  \ $$ |$$$$$$$  |/$$$$$$  |      $$$$$$$  |$$$$$$$$/       $$$$$$$  |/$$$$$$  |$$  \ $$ |      /$$$$$$  |$$ |  $$ |$$ |  $$ |/$$$$$$  |$$ |  $$ |/$$$$$$  |
   $$ |     $$ |  $$ |__    $$$  \$$ |$$ |  $$ |$$ |__$$ |      $$ |  $$ |$$ |__          $$ |  $$ |$$ |  $$ |$$$  \$$ |      $$ |  $$/ $$ |__$$ |$$ |  $$ |$$ |  $$/ $$ |__$$ |$$ |  $$ |
   $$ |     $$ |  $$    |   $$$$  $$ |$$ |  $$ |$$    $$ |      $$ |  $$ |$$    |         $$ |  $$ |$$ |  $$ |$$$$  $$ |      $$ |      $$    $$ |$$ |  $$ |$$ |      $$    $$ |$$ |  $$ |
   $$ |     $$ |  $$$$$/    $$ $$ $$ |$$ |  $$ |$$$$$$$$ |      $$ |  $$ |$$$$$/          $$ |  $$ |$$ |  $$ |$$ $$ $$ |      $$ |   __ $$$$$$$$ |$$ |  $$ |$$ |   __ $$$$$$$$ |$$ |  $$ |
   $$ |    _$$ |_ $$ |_____ $$ |$$$$ |$$ |__$$ |$$ |  $$ |      $$ |__$$ |$$ |_____       $$ |__$$ |$$ \__$$ |$$ |$$$$ |      $$ \__/  |$$ |  $$ |$$ \__$$ |$$ \__/  |$$ |  $$ |$$ \__$$ |
   $$ |   / $$   |$$       |$$ | $$$ |$$    $$/ $$ |  $$ |      $$    $$/ $$       |      $$    $$/ $$    $$/ $$ | $$$ |      $$    $$/ $$ |  $$ |$$    $$/ $$    $$/ $$ |  $$ |$$    $$/ 
   $$/    $$$$$$/ $$$$$$$$/ $$/   $$/ $$$$$$$/  $$/   $$/       $$$$$$$/  $$$$$$$$/       $$$$$$$/   $$$$$$/  $$/   $$/        $$$$$$/  $$/   $$/  $$$$$$/   $$$$$$/  $$/   $$/  $$$$$$/  
                                                                                                                                                                                          
                                                                                                                                                                                          
                                                                                                                                                                                          
         Elija una de las opciones";
            string[] options = { "Consultar precios", "Calculadora de ventas","Registro", "Acerca de", "Salir" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunBuscador();
                    break;
                case 1:
                    RunCalculadora();
                    break;
                case 2:
                    RunRegistro();
                    break;
                case 3:
                    AcercaDe();
                    break;
                case 4:
                    ExitShop();
                    break;
                default:
                    break;
            }
        }

        private void ExitShop()
        {
            WriteLine("\nPresione cualquier tecla para salir");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void AcercaDe()
        {
            Clear();
            WriteLine("Este programa fue creado por Juan Jose Tamayo Zuluaga, Juan José Amaya y Martin Jerónimo Zuluaga Orrego");
            WriteLine("Presione cualquier tecla para volver al menu principal");
            ReadKey(true);
            RunMainMenu();
        }

        private void RunBuscador()
        {
            string producto;
            float leche = 3000;
            float huevos = 23000;
            float galletas = 20000;
            float arepas = 12000;

            Clear();

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
                Console.WriteLine("Presione cualquier telca para volver");
                ReadKey(true);
                RunMainMenu();
            }

            if (producto == "Huevos")
            {
                Console.WriteLine("El precio del producto es" + huevos);
                Console.ReadLine();
                Console.WriteLine("Presione cualquier telca para volver");
                ReadKey(true);
                RunMainMenu();
            }

            if (producto == "Arepas")
            {
                Console.WriteLine("El precio del producto es" + arepas);
                Console.ReadLine();
                Console.WriteLine("Presione cualquier telca para volver");
                ReadKey(true);
                RunMainMenu();
            }

            if (producto == "Leche")
            {
                Console.WriteLine("El precio del producto es" + leche);
                Console.ReadLine();
                Console.WriteLine("Presione cualquier telca para volver");
                ReadKey(true);
                RunMainMenu();
            }

            else
            {
                Console.WriteLine("Producto no encontrado, por favor presione cualquier tecla para intentar denuevo");
                ReadKey(true);
                RunBuscador();

            }

        }
        private void RunCalculadora()
        {

            Clear();
            int Preciol = 3000; int Precioh = 23000; int Preciog = 20000; int Precioa = 12000; int sum = 0; int cant = 0; int importe = 0; int importe1 = 0; int importe2 = 0; int importe3 = 0;
            Console.WriteLine("\tiendita ");
            Console.WriteLine("\tVentas");
            Console.WriteLine("\n\nArticulo1");
            Console.WriteLine("\nleche   ");

            Console.WriteLine("Precio de la leche : 3000 ");
            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
            importe = cant * Preciol;
            Console.WriteLine("Importe : {0}", importe);
            Console.WriteLine("\n\nArticulo2");
            Console.WriteLine("\nhuevos   ");

            Console.WriteLine("Precio huevos :23000 ");
            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
            importe1 = cant * Precioh;
            Console.WriteLine("Importe : {0}", importe1);
            Console.WriteLine("\n\nArticulo3");
            Console.WriteLine("\ngalletas   ");

            Console.WriteLine("Precio galletas : 20000 ");
            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
            importe2 = cant * Preciog;
            Console.WriteLine("Importe : {0}", importe2);
            Console.WriteLine("\n\nArticulo4");
            Console.WriteLine("\narepas   ");

            Console.WriteLine("Precio arepas : 12000 ");
            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());
            importe3 = cant * Precioa;
            Console.WriteLine("Importe : {0}", importe3);

            sum = importe + importe1 + importe2 + importe3;
            Console.WriteLine("\n\n\tEl Total a Pagar es de : {0}", sum);

            Console.WriteLine("Presione cualquier telca para volver");
            ReadKey(true);
            RunMainMenu();
        }
        public void RunRegistro()
        {
            Clear();

            ClassCliente Cliente;

            Cliente = new ClassCliente();

            string filePath = @"C:\Users\juanj\source\repos\AppTienda\AppTienda\data.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

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

            lines.Add(Cliente.Apellidos);
            lines.Add(Cliente.Nombres);
            lines.Add(Cliente.CC);
            lines.Add(Cliente.Direccion);
            lines.Add(Cliente.Municipio);
            lines.Add("----------------");

            File.WriteAllLines(filePath, lines);








            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + ", " + Cliente.Municipio);
            Console.WriteLine(Cliente.CC);
            if (Cliente.EsCredito)
            {
                Console.WriteLine("El cliente tiene credito");
                Cliente.EsCredito = true;
            }
            else
            {
                Console.WriteLine("El cliente no tiene credito");
                Cliente.EsCredito = false;
            }
            
            Console.WriteLine("Se ha guardado los datos del cliente en el archivo TXT.  Presione cualquier telca para volver");
            ReadKey(true);
            RunMainMenu();
        }
    }
}
