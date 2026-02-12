using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace L4_CALA_1129526
{
    internal class Program
    {
        static void Main(string[] args)
        { Console.Write("¿Como te llamas? ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", bienvenido a la programación en C#");

            //Ejercicio 1
            string nave_espacial;
            int capacidad;
            float combustible;
            bool motor = true;

            Console.WriteLine("Ingrese Modelo de la nave");
            nave_espacial = Console.ReadLine();

            Console.WriteLine("Ingrese la capacidad de la aeronave");
            capacidad = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese nivel de combustible");
            combustible = float.Parse(Console.ReadLine());

            Console.WriteLine("¿El Motor de salto esta activo o no? Escriba true o false");
            motor = bool.Parse(Console.ReadLine());

            if (motor == true)
            {
                Console.Write("El motor de salto esta activo -");
            }
            else
            {
                Console.Write("El motor de salto no esta activo -");
            }
            Console.WriteLine("/el modelo de la naves es: " + nave_espacial + "/ con una capacidad de: " + capacidad + " toneladas /con un nivel de combustible de: " + combustible + " litros");

            // Ejercicio 2
            short Sensores_Activos = 128;
            int Registro_Procesador;
            float Precision_Total;

            Registro_Procesador = Sensores_Activos;
            Precision_Total = Registro_Procesador;

            Console.WriteLine(Precision_Total);



            // Ejercicio 3

            double Energia_Generada = 987.65;
            int energia_limitada;

            energia_limitada = (int)Energia_Generada;

            Console.WriteLine("La energia generada es: " + Energia_Generada + " y la energia limitada es: " + energia_limitada);




            // Ejercicio 4

            string entradaRadar;
            int distancia_planeta;
            int resultado;

            Console.WriteLine("Ingrese la distancia al planeta más cercano");
            entradaRadar = Console.ReadLine();

            distancia_planeta = int.Parse(entradaRadar );

            resultado = distancia_planeta + 100;

            Console.WriteLine("La distancia al planeta más cercano es:  " + resultado);


            // Ejercicio 5

            string temperaturacabina ="22.8";
            string Señal_oxigeno = "true";

            Convert.ToBoolean(Señal_oxigeno );

            Convert.ToDouble(temperaturacabina);

            Console.WriteLine("La temperatura de la cabina es: " + temperaturacabina + " y la señal de oxigeno es: " + Señal_oxigeno);


            // Ejercicio 6

            double velocidad_luz= 299792.458;
            string reportesimple = velocidad_luz.ToString();
            string reporteconformato = velocidad_luz.ToString("N3");

            Console.WriteLine(" El reporte sin formato " + reportesimple);
            Console.WriteLine(" El reporte con formato " + reporteconformato);

            // Ejercicio 7

            string entrada_usuario;
            double precio;
            double impuesto_Galactico;
            double Costo_total;
            int valor_redondo;

            Console.WriteLine("Ingrese el valor del precio por Galon de litio");
            entrada_usuario = Console.ReadLine();

            precio = Convert.ToDouble(entrada_usuario);

            impuesto_Galactico = precio * 0.12;

            Costo_total = precio + impuesto_Galactico;

            valor_redondo = (int)Costo_total;

            Console.WriteLine("El precio por galon de litio es: " + precio + " el impuesto galactico es: " + impuesto_Galactico + " y el costo total es: " + Costo_total + " El Costo redondeado es: " + valor_redondo);




        }
    }
}  

