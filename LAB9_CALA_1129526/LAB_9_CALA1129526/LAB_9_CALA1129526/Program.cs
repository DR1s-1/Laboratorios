using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9_CALA1129526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configuración inicial de consola
            Console.WriteLine("Laboratorio 9 - Procedimientos");
            Console.WriteLine("------------------------------");

            // Ejecución de Ejercicios
            EjecutarEjercicio1();
            EjecutarEjercicio2();
            EjecutarEjercicio3();
            EjecutarEjercicio4();
            EjecutarEjercicio5();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        // --- EJERCICIO 1: Saludo modularizado ---
        static void EjecutarEjercicio1()
        {
            Console.WriteLine("\n--- Ejercicio 1 ---");
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            MostrarSaludo(nombre); // Parámetro por valor [cite: 41]
            MostrarInfoCurso();
        }

        static void MostrarSaludo(string nombre)
        {
            Console.WriteLine($"Hola, {nombre}! Bienvenido al programa.");
        }

        static void MostrarInfoCurso()
        {
            Console.WriteLine("Curso: Lab - Pensamiento Computacional - Laboratorio 09");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        // --- EJERCICIO 2: Calculadora de áreas ---
        static void EjecutarEjercicio2()
        {
            Console.WriteLine("\n--- Ejercicio 2: Áreas ---");

            Console.Write("Lado del cuadrado: ");
            double lado = double.Parse(Console.ReadLine());
            AreaCuadrado(lado);

            Console.Write("Base del rectángulo: ");
            double bRec = double.Parse(Console.ReadLine());
            Console.Write("Altura del rectángulo: ");
            double hRec = double.Parse(Console.ReadLine());
            AreaRectangulo(bRec, hRec);

            Console.Write("Base del triángulo: ");
            double bTri = double.Parse(Console.ReadLine());
            Console.Write("Altura del triángulo: ");
            double hTri = double.Parse(Console.ReadLine());
            AreaTriangulo(bTri, hTri);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void AreaCuadrado(double l) => Console.WriteLine($"Área Cuadrado: {l * l}");
        static void AreaRectangulo(double b, double h) => Console.WriteLine($"Área Rectángulo: {b * h}");
        static void AreaTriangulo(double b, double h) => Console.WriteLine($"Área Triángulo: {(b * h) / 2}");


        // --- EJERCICIO 3: Menú de figuras ---
        static void EjecutarEjercicio3()
        {
            int opcion;
            do
            {
                Console.WriteLine("\n--- Ejercicio 3: Menú ---");
                Console.WriteLine("1. Cuadrado\n2. Triángulo\n3. Línea\n4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion >= 1 && opcion <= 3)
                {
                    Console.Write("Ingrese el valor de N: ");
                    int n = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: DibujarCuadrado(n); 
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey(); 
                            Console.Clear(); break;
                        case 2: DibujarTriangulo(n);
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear(); break; 
                        case 3: DibujarLinea(n);
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear(); break;
                    }
                }
            } while (opcion != 4);
            Console.WriteLine();
            Console.Clear();
        }

        static void DibujarCuadrado(int n)
        {
            for (int i = 0; i < n; i++)
            {
                DibujarLinea(n);
            }
        }

        static void DibujarTriangulo(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                DibujarLinea(i);
            }
        }

        static void DibujarLinea(int n)
        {
            Console.WriteLine(new string('*', n));
        
        }

        // --- EJERCICIO 4: Registro de notas ---
        static void EjecutarEjercicio4()
        {
            Console.WriteLine("\n--- Ejercicio 4: Notas ---");
            double suma = 0;
            int aprobados = 0, reprobados = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese nota {i}: ");
                double nota = double.Parse(Console.ReadLine());
                suma += nota;

                if (EsAprobado(nota)) aprobados++;
                else reprobados++;
            }

            MostrarResumen(suma / 5, aprobados, reprobados);
        }

        static bool EsAprobado(double nota)
        {
            bool aprobado = nota >= 61;
            Console.WriteLine(aprobado ? "Resultado: Aprobado" : "Resultado: Reprobado");
            return aprobado;
          
        }

        static void MostrarResumen(double prom, int apr, int repr)
        {
            Console.WriteLine($"\nRESUMEN:\nPromedio: {prom}\nAprobados: {apr}\nReprobados: {repr}");
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            // --- EJERCICIO 5: Intercambio (ref) ---


        }
        static void EjecutarEjercicio5()
        {
            Console.WriteLine("\n--- Ejercicio 5: Intercambio ---");
            Console.Write("Número A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Número B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Antes: A={a}, B={b}");
            Console.WriteLine($"Después: A={b}, B={a}");


        }
        static void Intercambiar(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
         
        }
    }
}

