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
            int cantidad, suma;
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
                contador++;
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

            Console.WriteLine();
            Console.WriteLine("Menú de conversión de unidades");

            Console.WriteLine("conversion de grados Celsius a Fahrenheit");
            float celsius, fahrenheit;
            float kilometros, millas;
            int opcion;

            // menu de opciones
            Console.WriteLine();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Convertir grados Celsius a Fahrenheit");
            Console.WriteLine("2. convertir grados Fahrenheit a Celcius");
            Console.WriteLine("3. Convertir kilómetros a millas");

            do
            {
                Console.WriteLine();
                Console.Write("Ingrese su opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Ingrese la temperatura en grados Celsius: ");
                        celsius = float.Parse(Console.ReadLine());
                        fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.Write("Ingrese la temperatura en grados Fahrenheit: ");
                        fahrenheit = float.Parse(Console.ReadLine());
                        celsius = (fahrenheit - 32) * 5 / 9;
                        Console.WriteLine("La temperatura en grados Celsius es: " + celsius);
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.Write("Ingrese la distancia en kilómetros: ");
                        kilometros = float.Parse(Console.ReadLine());
                        millas = kilometros * 0.621371f;
                        Console.WriteLine("La distancia en millas es: " + millas);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            } while (opcion < 1 || opcion > 3);



            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            //Ejercicio #3 

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); // Genera número entre 1 y 100 
            int intentos = 0;
            int suposicion = 0;

            Console.WriteLine("¡Bienvenido al juego de adivinar el número!");
            Console.WriteLine("He pensado un número entre 1 y 100.");

            // Proceso iterativo para adivinar
            while (suposicion != numeroSecreto)
            {
                Console.Write("Ingresa tu número: ");

                // Validación de entrada numérica
                if (int.TryParse(Console.ReadLine(), out suposicion))
                {
                    // Validación de rango 
                    if (suposicion < 1 || suposicion > 100)
                    {
                        Console.WriteLine("Error: El número debe estar entre 1 y 100. Este intento no cuenta.");
                        continue; // Reinicia el ciclo sin contar el intento 
                    }

                    intentos++; // Solo se cuenta si el número es válido 

                    // Pistas de proximidad 
                    if (suposicion < numeroSecreto)
                    {
                        Console.WriteLine("Más alto");
                    }
                    else if (suposicion > numeroSecreto)
                    {
                        Console.WriteLine("Más bajo");
                    }
                    else
                    {
                        // Salida final al acertar 
                        Console.WriteLine($"¡Correcto! El número era {numeroSecreto}.");
                        Console.WriteLine($"Cantidad de intentos válidos: {intentos}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                }


            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio #4

            string PIN_CORRECTO = "1234"; // PIN definido en la guía 
            int inten = 0;
            string pinIngresado = "";
            bool accesoConcedido = false;

            Console.WriteLine("--- Sistema de Acceso ---");

            // Ciclo DO-WHILE para controlar los intentos 
            do
            {
                inten++; // Incrementa el contador en cada vuelta 
                Console.Write($"Intento {inten}/3 - Ingrese su PIN: ");
                pinIngresado = Console.ReadLine();

                if (pinIngresado == PIN_CORRECTO)
                {
                    accesoConcedido = true;
                    Console.WriteLine("Acceso concedido"); // Mensaje de éxito 
                }
                else
                {
                    // Si no es el último intento, muestra que es incorrecto 
                    if (inten < 3)
                    {
                        Console.WriteLine("PIN incorrecto.");
                    }
                }

            } while (!accesoConcedido && inten < 3); 

            // Resultado final si se agotan los intentos
            if (!accesoConcedido)
            {
                Console.WriteLine("Cuenta bloqueada"); 
            }



        }
    }
}
