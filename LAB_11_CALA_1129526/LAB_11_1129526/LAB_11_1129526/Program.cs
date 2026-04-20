using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_11_1129526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido(a), " + nombre);

            // Llamada a los ejercicios
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
        }

        static void Ejercicio1()
        {
            Console.WriteLine("--- Ejercicio 1: Validación de Contraseña ---");
            Console.Write("Ingrese contraseña: ");
            string pass = Console.ReadLine();

            bool largo = pass.Length >= 8;
            bool mayus = false, num = false, especial = false;
            string especiales = "@#$%";

            foreach (char c in pass)
            {
                if (char.IsUpper(c)) mayus = true;
                if (char.IsDigit(c)) num = true;
                if (especiales.Contains(c)) especial = true;
            }

            if (largo && mayus && num && especial)
            {
                Console.WriteLine("Resultado: Contraseña válida\n");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Resultado: Inválida");
                if (!largo) Console.WriteLine("- Falta longitud mínima (8)");
                if (!mayus) Console.WriteLine("- Falta al menos 1 mayúscula");
                if (!num) Console.WriteLine("- Falta al menos 1 número");
                if (!especial) Console.WriteLine("- Falta carácter especial (@, #, $, %)\n");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            }
        }

        static void Ejercicio2()
        {
            Console.WriteLine("--- Ejercicio 2: Invertir Texto ---");
            Console.Write("Ingrese una cadena: ");
            string original = Console.ReadLine();
            string invertida = "";

            // Recorrido desde el final al inicio sin funciones automáticas
            for (int i = original.Length - 1; i >= 0; i--)
            {
                invertida += original[i];
            }
            Console.WriteLine("Resultado: " + invertida + "\n");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }

        static void Ejercicio3()
        {
            Console.WriteLine("--- Ejercicio 3: Suma y Promedio ---");
            Console.Write("¿Cuántos números desea ingresar?: ");
            int n = int.Parse(Console.ReadLine());
            double[] numeros = new double[n];

            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                numeros[i] = double.Parse(Console.ReadLine());
                suma += numeros[i];
            }

            double mayor = numeros[0], menor = numeros[0];
            foreach (double num in numeros)
            {
                if (num > mayor) mayor = num;
                if (num < menor) menor = num;
            }

            Console.WriteLine($"Suma = {suma}, Promedio = {suma / n}, Mayor = {mayor}, Menor = {menor}\n");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Ejercicio4()
        {
            Console.WriteLine("--- Ejercicio 4: Buscar un Número ---");
            int[] arreglo = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Ingrese número {i + 1}/8: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Número a buscar: ");
            int buscar = int.Parse(Console.ReadLine());
            int posicion = -1;

            for (int i = 0; i < 8; i++)
            {
                if (arreglo[i] == buscar)
                {
                    posicion = i;
                    break; // Muestra la primera posición encontrada
                }
            }

            if (posicion != -1)
                Console.WriteLine($"El número sí existe en la posición {posicion}\n");
            else
                Console.WriteLine("El número no existe en el arreglo\n");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Ejercicio5()
        {
            Console.WriteLine("--- Ejercicio 5: Nombres en Arreglo ---");
            string[] nombres = new string[5];
            int masDe5 = 0;
            string nombreMasLargo = "";

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese nombre {i + 1}: ");
                nombres[i] = Console.ReadLine();

                if (nombres[i].Length > 5) masDe5++;
                if (nombres[i].Length > nombreMasLargo.Length) nombreMasLargo = nombres[i];
            }

            Console.WriteLine("Nombres ingresados: " + string.Join(", ", nombres));
            Console.WriteLine($"Más de 5 letras: {masDe5}");
            Console.WriteLine($"Nombre más largo: {nombreMasLargo}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}






































    
    

