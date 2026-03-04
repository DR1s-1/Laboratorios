using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_CALA71129526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            // Proceso + Salida
            Console.WriteLine("Hola, " + nombre + ". ¡Bienvenido/a al Laboratorio7!");

            //Ejercicio #1
            int cantidad,suma;
            int contador = 1;   
            float promedio;

            Console.WriteLine();
            Console.Write("Ingrese la cantidad de numero que desea sumar: ");
            cantidad = int.Parse(Console.ReadLine());
            while (cantidad <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("La cantidad debe ser mayor a cero. Intente nuevamente.");
                Console.Write("Ingrese la cantidad de numero que desea sumar: ");
                cantidad = int.Parse(Console.ReadLine());
            }
             suma = 0;

            while (contador <= cantidad)
            {
                suma = suma + contador;
                contador ++;
            }
            Console.WriteLine();
            Console.WriteLine("La suma de los numeros es: " + suma);

            promedio = suma / cantidad;

            Console.WriteLine("El promedio de los numeros es: " + promedio);



            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            //Ejercicio #2 Menú repetitivo de conversión de unidades (DO-WHILE)

            Console.WriteLine("Menú de conversión de unidades");







        }
    }
}
