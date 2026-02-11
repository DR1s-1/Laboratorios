using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace L4_CALA_1129526
{
    internal class Program
    {
        static void Main(string[] args)
        {Console.Write("¿Como te llamas? ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", bienvenido a la programación en C#");

            //Ejercicio 1
            string nave_espacial;
            int capacidad;
            float combustible;
            bool motor_activo;

            Console.WriteLine( "Ingese Modelo de la nave");
            nave_espacial=Console.ReadLine();

            Console.WriteLine("Ingrese la capacidad de la aeronave");
            capacidad=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese nivel de combustible");
            combustible=float.Parse(Console.ReadLine());   



        }
    }
}

