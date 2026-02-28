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

            Console.WriteLine("Ejercicio #1");

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
            else if (vehiculo.ToLower() == carro)
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

            Console.WriteLine("Ejercicio #2");


            string tipo;
            double lim;

            Console.WriteLine("Ingrese su tipo de tarjeta, escriba una de las siguientes opciones, tipo 1/2/3/otro");
            tipo = Console.ReadLine();

            Console.WriteLine("Ingrese su limite de credito actual");
            lim = Convert.ToDouble(Console.ReadLine());

            if (tipo.ToLower() == "1")
            {
                lim = lim * 0.25 + lim;
                Console.WriteLine("Su nuevo limite de credito tiene un aumento del 25%  " + lim);
            }
            else if (tipo.ToLower() == "2")
            {
                lim = lim * 0.35 + lim;
                Console.WriteLine("Su nuevo limite de credito tiene un aumento del 35%  " + lim);
            }
            else if (tipo.ToLower() == "3")
            {
                lim = lim * 0.40 + lim;
                Console.WriteLine("Su nuevo limite de credito tiene un aumento del 40%  " + lim);
            }
            else
            {
                lim = lim * 0.50 + lim;
                Console.WriteLine("Su nuevo limite de credito tiene un aumento del 50%  " + lim);

            }

            // Ejercicio #3


            Console.WriteLine("Ejercicio #3");



            double puntos;
            double sueldo = 2400;
            double sueldo_aum;

            Console.WriteLine("Ingrese su cantidad de puntos , escriba una de las siguientes opciones, 0.0/0.4/0.6");
            puntos = double.Parse(Console.ReadLine());


            if (puntos == 0.0)
            {
                sueldo_aum = sueldo * 0.0 + sueldo;
                Console.WriteLine("Su desempeño a lo largo del año a sido inaceptable, su aumento sera de 0.0 puntos,  " + sueldo_aum);
            }
            else if (puntos == 0.4)
            {
                sueldo_aum = sueldo * 0.4 + sueldo;
                Console.WriteLine("Su desempeño a lo largo del año a sido aceptable, su aumento sera de 0.4 puntos,  " + sueldo_aum);
            }
            else if (puntos == 0.6)
            {
                sueldo_aum = sueldo * 0.6 + sueldo;
                Console.WriteLine("Su desempeño a lo largo del año a sido meritorio, su aumento sera de 0.6 puntos,  " + sueldo_aum);
            }


            // Ejercicio #4 Bella Napoli


            Console.WriteLine("Ejercicio #4");


            string tipo_pizza;
            string ingrediente;

            Console.WriteLine("Que tipo de pizza le gustaria ordenar?, vegetariana o no vegetariana");
            tipo_pizza = Console.ReadLine();

            if (tipo_pizza.ToLower() == "vegetariana")
            {
                Console.WriteLine("Ingredientes disponibles: Pimiento, Champiñones, Tomate y Tofu");
            }
            else if (tipo_pizza.ToLower() == "no vegetariana")
            {
                Console.WriteLine("Ingredientes disponibles: Peperoni, Jamón, Salmón y Camarón ");
            }

            Console.WriteLine("Ingrese el ingrediente que desea agregar a su pizza");
            ingrediente = Console.ReadLine();

            if (tipo_pizza.ToLower() == "vegetariana")
            {
                if (ingrediente.ToLower() == "pimiento" || ingrediente.ToLower() == "champiñones" || ingrediente.ToLower() == "tomate" || ingrediente.ToLower() == "tofu")
                {
                    Console.WriteLine("Ingrediente agregado a su pizza vegetariana: " + ingrediente);
                }
                else
                {
                    Console.WriteLine("Ingrediente no disponible para pizza vegetariana");
                }
            }
            else if (tipo_pizza.ToLower() == "no vegetariana")
            {
                if (ingrediente.ToLower() == "peperoni" || ingrediente.ToLower() == "jamón" || ingrediente.ToLower() == "salmón" || ingrediente.ToLower() == "camarón")
                {
                    Console.WriteLine("Ingrediente agregado a su pizza no vegetariana: " + ingrediente);
                }
                else
                {
                    Console.WriteLine("Ingrediente no disponible para pizza no vegetariana");
                }
            }

            Console.WriteLine("Gracias por su orden, su pizza estará lista en 20 minutos.");
        }
    }
}
