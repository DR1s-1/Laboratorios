using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_CALA1129526
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

            // Ejercicio #1
            string bici = "bicicleta";
            string moto = "motocicleta";
            string carro = "carro";
            string camion = "camión";
            string bus = "bus";
            string vehiculo;

            Console.WriteLine("Ingrese el vehiculo");
            vehiculo = Console.ReadLine();


            if (vehiculo.ToLower() == bici)
            {
                Console.WriteLine("No motorizado");
            }
            else if (vehiculo.ToLower() == moto)
            {
                Console.WriteLine(" Ligero");
            }
            else if (vehiculo.ToLower()== carro)
            {
                Console.WriteLine("Mediano ");
            }
            else if (vehiculo.ToLower() == camion)
            {
                Console.WriteLine(" Pesado ");
            }
            else if (vehiculo.ToLower() == bus)
            {
                Console.WriteLine("Transporte público");
            }
            else
            {                
                Console.WriteLine("Vehículo no reconocido"); 
            }


            // Ejercicio #2 Banco Industrial

            string TT1;







        }
    }
}
