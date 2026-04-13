using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_CALA_1129526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Bienvenida ---
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola, {nombre} ¡Bienvenido a C#!\n");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // --- EJERCICIO 1: Suma de Dígitos ---
            Console.WriteLine("--- Ejercicio 1: Suma de Dígitos ---");
            Console.Write("Ingrese un número entero positivo: ");
            if (int.TryParse(Console.ReadLine(), out int numUsuario))
            {
                int resultadoSuma = SumarDigitos(numUsuario);
                Console.WriteLine($"La suma de los dígitos de {numUsuario} es: {resultadoSuma}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // --- EJERCICIO 2: Elevar al Cuadrado (ref) ---
            Console.WriteLine("\n--- Ejercicio 2: Elevar al Cuadrado ---");
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine($"Valor inicial: {N}");
                string mensajeCuadrado = ElevarAlCuadrado(ref N);
                Console.WriteLine(mensajeCuadrado);
                Console.WriteLine($"Nuevo valor (modificado por ref): {N}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // --- EJERCICIO 3: Descuento Dinámico ---
            Console.WriteLine("\n--- Ejercicio 3: Descuento Dinámico ---");
            Console.Write("Ingrese el precio: ");
            if (double.TryParse(Console.ReadLine(), out double precioProducto))
            {
                Console.Write("Ingrese el porcentaje (ej. 0.20 para 20%): ");
                if (double.TryParse(Console.ReadLine(), out double porcentaje))
                {
                    double ahorro = AplicarDescuento(porcentaje, ref precioProducto);
                    Console.WriteLine($"Monto descontado: {ahorro}");
                    Console.WriteLine($"Precio final: {precioProducto}");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // --- EJERCICIO 4: Sistema de Energía ---
            Console.WriteLine("\n--- Ejercicio 4: Sistema de Energía ---");
            Console.Write("Ingrese energía inicial (0-20): ");
            if (int.TryParse(Console.ReadLine(), out int energiaJugador))
            {
                
                string estadoActual = ObtenerEstado(energiaJugador);
                Console.WriteLine($"Estado inicial: {estadoActual}");

               
                ConsumirEnergia(ref energiaJugador);
                string rendimientoActual = CalcularRendimiento(energiaJugador);
                Console.WriteLine($"\nTras consumir (-4): {energiaJugador}");
                Console.WriteLine($"Rendimiento actual: {rendimientoActual}");

                RecargarEnergia(ref energiaJugador);
                estadoActual = ObtenerEstado(energiaJugador); 
                Console.WriteLine($"\nTras recargar (+6): {energiaJugador}");
                Console.WriteLine($"Nuevo estado: {estadoActual}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }


        // --- FUNCIONES ---

        static int SumarDigitos(int numero)
        {
            int suma = 0;
            numero = Math.Abs(numero);
            while (numero > 0)
            {
                suma += numero % 10;
                numero /= 10;
            }
            return suma;
        }

        static string ElevarAlCuadrado(ref int n)
        {
            n = n * n;
            return "Operación realizada exitosamente.";
        }

        static double AplicarDescuento(double porcentaje, ref double precio)
        {
            double montoDescontado = precio * porcentaje;
            precio = precio - montoDescontado;
            return montoDescontado;
        }

        static int ConsumirEnergia(ref int energia)
        {
            energia -= 4;
            if (energia < 0) energia = 0;
            return energia;
        }

        static int RecargarEnergia(ref int energia)
        {
            energia += 6;
            if (energia > 20) energia = 20;
            return energia;
        }

        static string ObtenerEstado(int energia)
        {
            if (energia >= 15) return "Alta";
            if (energia >= 8) return "Media";
            return "Baja";
        }

        static string CalcularRendimiento(int energia)
        {
            if (energia == 20) return "S";
            if (energia >= 15) return "A";
            if (energia >= 8) return "B";
            if (energia >= 1) return "C";
            return "Sin energía";
        }
    }
}