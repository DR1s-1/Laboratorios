using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_CALA_1129526
{
    internal class Program
    {
        static void Main()
        {

            // Entrada de usuario
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();
            // Salida de datos
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("=== LABORATORIO 12: MATRICES (ARREGLOS BIDIMENSIONALES) ===\n");

            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();

       
        }

        // ==================== EJERCICIO 1 ====================
        static void Ejercicio1()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 1: Suma de filas y columnas ===\n");

            int[,] matriz = new int[4, 4];

            LlenarMatriz(matriz);

            Console.WriteLine("\nMatriz ingresada:");
            MostrarMatriz(matriz);

            Console.Write("\nIngrese el número de fila para calcular la suma (0-3): ");
            int fila = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columna para calcular la suma (0-3): ");
            int columna = int.Parse(Console.ReadLine());

            int sumaF = SumaFila(matriz, fila);
            int sumaC = SumaColumna(matriz, columna);

            Console.WriteLine($"\nSuma de la fila {fila}: {sumaF}");
            Console.WriteLine($"Suma de la columna {columna}: {sumaC}");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        static void LlenarMatriz(int[,] m)
        {
            Console.WriteLine("Ingrese los elementos de la matriz 4x4:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static int SumaFila(int[,] m, int fila)
        {
            int suma = 0;
            for (int j = 0; j < 4; j++)
            {
                suma += m[fila, j];
            }
            return suma;
        }

        static int SumaColumna(int[,] m, int col)
        {
            int suma = 0;
            for (int i = 0; i < 4; i++)
            {
                suma += m[i, col];
            }
            return suma;
        }

        static void MostrarMatriz(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"{m[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        // ==================== EJERCICIO 2 ====================
        static void Ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 2: Número mayor en matriz ===\n");

            float[,] matriz = new float[3, 5];

            CargarMatriz(matriz);

            Console.WriteLine("\nMatriz ingresada:");
            MostrarMatrizFloat(matriz);

            float mayor = MayorMatriz(matriz);

            Console.WriteLine($"\nEl número mayor en la matriz es: {mayor}");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        static void CargarMatriz(float[,] m)
        {
            Console.WriteLine("Ingrese los elementos de la matriz 3x5:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    m[i, j] = float.Parse(Console.ReadLine());
                }
            }
        }

        static float MayorMatriz(float[,] m)
        {
            float mayor = m[0, 0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (m[i, j] > mayor)
                    {
                        mayor = m[i, j];
                    }
                }
            }

            return mayor;
        }

        static void MostrarMatrizFloat(float[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"{m[i, j],8:F2} ");
                }
                Console.WriteLine();
            }
        }

        // ==================== EJERCICIO 3 ====================
        static void Ejercicio3()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 3: Multiplicación de matrices ===\n");

            int[,] A = new int[3, 2];
            int[,] B = new int[3, 2];
            int[,] R = new int[3, 2];

            Console.WriteLine("Matriz A (3x2):");
            LlenarMatrizA(A);

            Console.WriteLine("\nMatriz B (3x2):");
            LlenarMatrizB(B);

            Console.WriteLine("\nMatriz A:");
            MostrarMatrizInt(A, 3, 2);

            Console.WriteLine("\nMatriz B:");
            MostrarMatrizInt(B, 3, 2);

            Multiplicar(A, B, R);

            Console.WriteLine("\nMatriz Resultante (A * B):");
            MostrarMatrizInt(R, 3, 2);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        static void LlenarMatrizA(int[,] m)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento A[{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void LlenarMatrizB(int[,] m)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Elemento B[{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void Multiplicar(int[,] A, int[,] B, int[,] R)
        {


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    R[i, j] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        R[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
        }

        static void MostrarMatrizInt(int[,] m, int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{m[i, j],6} ");
                }
                Console.WriteLine();
            }
        }

        // ==================== EJERCICIO 4 ====================
        static void Ejercicio4()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 4: Diagonales principales y secundarias ===\n");

            int[,] matriz = new int[5, 5];

            Llenar(matriz);

            Console.WriteLine("\nMatriz 5x5:");
            MostrarMatrizInt(matriz, 5, 5);

            int sumaPrincipal = SumaDiagonalPrincipal(matriz);
            int sumaSecundaria = SumaDiagonalSecundaria(matriz);

            Console.WriteLine($"\nSuma de la diagonal principal: {sumaPrincipal}");
            Console.WriteLine($"Suma de la diagonal secundaria: {sumaSecundaria}");

            // Mostrar qué elementos se sumaron
            Console.WriteLine("\nElementos de la diagonal principal:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{matriz[i, i]} ");
            }

            Console.WriteLine("\n\nElementos de la diagonal secundaria:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{matriz[i, 4 - i]} ");
            }

            Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        static void Llenar(int[,] m)
        {
            Console.WriteLine("Ingrese los elementos de la matriz 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static int SumaDiagonalPrincipal(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += m[i, i];
            }
            return suma;
        }

        static int SumaDiagonalSecundaria(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += m[i, 4 - i];
            }
            return suma;
        }
    }
}
 