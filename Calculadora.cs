using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicialización de las variables
            double cantidad1;
            double cantidad2;
            string operacion;
            double resultado;

            Console.WriteLine("Que tipo de operacion desea realizar?");

            operacion = Console.ReadLine();


            Console.WriteLine("Digite la primer cantidad");
            cantidad1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite la segunda cantidad");
            cantidad2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if(operacion == "SUMA")
            {
                resultado = cantidad1 + cantidad2;
                Console.WriteLine("El resultado de la suma es:" + resultado);
                Console.ReadLine();
            }

            if(operacion == "RESTA")
            {
                resultado = cantidad1 - cantidad2;
                Console.WriteLine("El resultado de la resta es:" + resultado);
                Console.ReadLine();
            }

            if(operacion == "MULTIPLICACIÓN")
            {
                resultado = cantidad1 * cantidad2;
                Console.WriteLine("El resultado de la multiplicación es:" + resultado);
                Console.ReadLine();
            }

            if(operacion == "DIVISIÓN")
            {
                resultado = cantidad1 / cantidad2;
                Console.WriteLine("El resultado de la división es:" + resultado);
                Console.ReadLine();
            }
        }
    }
}
