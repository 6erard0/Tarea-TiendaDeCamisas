using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCamisas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bienvenido a la tienda de camisas***");
            Console.WriteLine(" ");

            while (true)
            {
                // Solicitar la cantidad de camisas al usuario
                Console.Write("Ingrese la cantidad de camisas que desea comprar: ");
                int cantidadCamisas = int.Parse(Console.ReadLine());

                // Solicitar el precio de costo por camisa al usuario
                Console.Write("Ingrese el precio de costo por camisa: ");
                double precioCostoPorCamisa = double.Parse(Console.ReadLine());

                // Calcular el precio total sin descuento
                double precioSinDescuento = cantidadCamisas * precioCostoPorCamisa;

                // Calcular el descuento según las reglas
                double descuento = 0.0;
                if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
                {
                    descuento = precioSinDescuento * 0.15; // 15% de descuento
                }
                else if (cantidadCamisas > 5)
                {
                    descuento = precioSinDescuento * 0.20; // 20% de descuento
                }

                // Calcular el precio total con descuento
                double precioConDescuento = precioSinDescuento - descuento;

                // Mostrar resultados
                Console.WriteLine("\n  ***Resumen de la compra***");
                Console.WriteLine($"Cantidad de camisas: {cantidadCamisas}");
                Console.WriteLine($"Precio de costo por camisa: ${precioCostoPorCamisa}");
                Console.WriteLine($"Precio sin descuento: ${precioSinDescuento}");
                Console.WriteLine($"Descuento aplicado: ${descuento}");
                Console.WriteLine($"Precio con descuento: ${precioConDescuento}");

                // Pedir al usuario que presione Enter para salir o 1 para continuar
                Console.WriteLine("\nPresione Enter para salir o 1 para continuar...");
                string opcion = Console.ReadLine();

                if (opcion != "1")
                {
                    break; // Salir del bucle si no se ingresa "1"
                }
            }
        }

    }
}
