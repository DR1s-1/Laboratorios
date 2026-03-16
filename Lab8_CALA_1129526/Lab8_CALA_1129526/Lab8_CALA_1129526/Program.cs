using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_CALA_1129526
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();
       
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            // Ejercicio 1
            int note, cantidadapro = 0, CantRepro = 0, suma = 0;
            double promedio = 0;
            Console.WriteLine("Ejercicio #1");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese las notas");
                note = int.Parse(Console.ReadLine());
                if (note >= 65)
                {
                    cantidadapro++;
                }
                else
                {
                    CantRepro++;
                }
                suma = suma + note;
            }


            promedio = suma / 10;
            Console.WriteLine();
            Console.WriteLine("Su promedio fue de: " + promedio);
            Console.WriteLine();
            Console.WriteLine("Los aprobados fueron: " + cantidadapro);
            Console.WriteLine();
            Console.WriteLine("Los reprobados fueron: " + CantRepro);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            // Ejercicio 2
            int cantidad, suma2;
            int contador = 1, pares = 0, impares = 0;
            Console.WriteLine("Ejercicio #2");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Ingrese un numero entero : ");
            cantidad = int.Parse(Console.ReadLine());
            while (cantidad <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("La cantidad debe ser mayor a cero. Intente nuevamente.");
                Console.Write("Ingrese la cantidad de numero que desea sumar: ");
                cantidad = int.Parse(Console.ReadLine());
            }
            suma2 = 0;

            while (contador <= cantidad)
            {
                suma2 = suma2 + contador;
                contador++;

                if (contador % 2 == 0)
                {
                    pares++;

                }

                if (contador % 2 != 0)
                {
                    impares++;
                }

            }

            Console.WriteLine();
            Console.WriteLine("La suma de los numeros es: " + suma2);

            Console.WriteLine();
            Console.WriteLine("Cantidad de numeros pares en el rango propuesto: " + pares);
            Console.WriteLine();
            Console.WriteLine("Cantidad de numeros pares en el rango propuesto: " + impares);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            // Ejercicio #3
            int opcion = 0;
            double totalVentas = 0;
            int cantidadClientes = 0;
            double montoCompra = 0;

            Console.WriteLine("Ejercicio #3");
            Console.WriteLine();

            do
            {
                Console.WriteLine("\n--- MENÚ DE TIENDA ---");
                Console.WriteLine("1) Registrar compra");
                Console.WriteLine("2) Mostrar total de ventas");
                Console.WriteLine("3) Mostrar cantidad de clientes atendidos");
                Console.WriteLine("4) Salir");
                Console.Write("Seleccione una opción: ");

               
                if (int.TryParse(Console.ReadLine(), out opcion))
                {

                  
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingrese el monto de la compra: ");
                            montoCompra = Convert.ToDouble(Console.ReadLine());

                           
                            totalVentas += montoCompra;
                            cantidadClientes++;

                            Console.WriteLine("Compra registrada con éxito.");
                            break;

                        case 2:
                            
                            Console.WriteLine("El total de ventas del día es: Q" + totalVentas);
                            break;

                        case 3:
                           
                            Console.WriteLine("Clientes atendidos hoy: " + cantidadClientes);
                            break;

                        case 4:
                            
                            Console.WriteLine("Saliendo del sistema...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida, intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }

            } while (opcion != 4);

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            // Ejercicio #4

            int numero = 0;
            int totalIngresados = 0;
            int positivos = 0;
            int negativos = 0;
            int sumaTotal = 0;

            Console.WriteLine("Ejercicio #4");
            Console.WriteLine();

            Console.WriteLine("Ingrese números (ingrese 0 para finalizar):");

            
            do
            {
                Console.Write("Número: ");
                numero = int.Parse(Console.ReadLine());

               
                if (numero != 0)
                {
                    totalIngresados++; 
                    sumaTotal += numero; 

                   
                    if (numero > 0)
                    {
                        positivos++; 
                    }
                    else
                    {
                        negativos++; 
                    }
                }

            } while (numero != 0); 

            
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine("Total de números ingresados: " + totalIngresados);
            Console.WriteLine("Números positivos: " + positivos);
            Console.WriteLine("Números negativos: " + negativos);
            Console.WriteLine("Suma total: " + sumaTotal);


            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            // Ejercicio #5

            Console.WriteLine("Ejercicio #5");
            Console.WriteLine();

         
            Console.Write("Ingrese un número N para la figura: ");
            int N = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= N; i++)
            {

               
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); 
                }

             
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para Finalizar");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
