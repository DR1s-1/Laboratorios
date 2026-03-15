using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_CALA_1129526
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de usuario
            Console.Write("¿Cómo te llamas? ");
            string nombre = Console.ReadLine();
            // Salida de datos
            Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

            // Ejercicio 1
            int note, cantidadapro = 0, CantRepro = 0, suma = 0;
            double promedio = 0;
            Console.WriteLine("Ejercicio#1");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese las notas");
                note = int.Parse(Console.ReadLine());
                if (note <= 65)
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


            // Ejercicio 2




        }
    }
}
