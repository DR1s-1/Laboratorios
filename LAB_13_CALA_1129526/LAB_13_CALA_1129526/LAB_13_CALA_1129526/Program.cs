
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13_CALA_1129526
{
    internal class Program
    {
        // ==================== CLASE PERSONA ====================
        class Persona
        {
            public string nombre;
            public int edad;
            public double altura;
            public bool estudiante;
        }

        // ==================== CLASE VEHICULO ====================
        class Vehiculo
        {
            public string marca;
            public string modelo;
            public int anio;
            public string color;
            public string placa;
        }

        // ==================== CLASE PRODUCTO ====================
        class Producto
        {
            public string codigo;
            public string nombre;
            public double precio;
            public int stock;
            public bool disponible;
        }

        // ==================== CLASE MASCOTA ====================
        class Mascota
        {
            public string nombre;
            public string especie;
            public int edad;
            public double peso;
            public bool vacunado;
        }

        // ==================== MAIN ====================
        static void Main()
        {
            // Bienvenida
            Console.Write("¿Cómo te llamas? ");
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine("Hola, " + nombreUsuario + " ¡Bienvenido al Laboratorio 13!");

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("=== LABORATORIO 13: PROGRAMACION ORIENTADA A OBJETOS ===\n");

            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
        }

        // ==================== EJERCICIO 1 ====================
        static void Ejercicio1()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 1: CLASE PERSONA ===\n");

            // Crear objeto de tipo Persona
            Persona persona1 = new Persona();

            // Asignar valores a los atributos
            persona1.nombre = "Carlos Martinez";
            persona1.edad = 20;
            persona1.altura = 1.78;
            persona1.estudiante = true;

            // Mostrar los datos
            Console.WriteLine("Información de la Persona:");
            Console.WriteLine("Nombre: " + persona1.nombre);
            Console.WriteLine("Edad: " + persona1.edad);
            Console.WriteLine("Altura: " + persona1.altura);
            Console.WriteLine("Estudiante: " + persona1.estudiante);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        // ==================== EJERCICIO 2 ====================
        static void Ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 2: CLASE VEHICULO ===\n");

            // Crear objeto de tipo Vehiculo
            Vehiculo vehiculo1 = new Vehiculo();

            // Asignar valores a los atributos
            vehiculo1.marca = "Honda";
            vehiculo1.modelo = "Civic";
            vehiculo1.anio = 2022;
            vehiculo1.color = "Gris";
            vehiculo1.placa = "XYZ-789";

            // Mostrar la información
            Console.WriteLine("Información del Vehículo:");
            Console.WriteLine("Marca: " + vehiculo1.marca);
            Console.WriteLine("Modelo: " + vehiculo1.modelo);
            Console.WriteLine("Año: " + vehiculo1.anio);
            Console.WriteLine("Color: " + vehiculo1.color);
            Console.WriteLine("Placa: " + vehiculo1.placa);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        // ==================== EJERCICIO 3 ====================
        static void Ejercicio3()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 3: CLASE PRODUCTO ===\n");

            // Crear primer objeto de tipo Producto
            Producto producto1 = new Producto();

            producto1.codigo = "PRD001";
            producto1.nombre = "Teclado Mecánico";
            producto1.precio = 75.50;
            producto1.stock = 15;
            producto1.disponible = true;

            Console.WriteLine("Producto 1:");
            Console.WriteLine("Código: " + producto1.codigo);
            Console.WriteLine("Nombre: " + producto1.nombre);
            Console.WriteLine("Precio: " + producto1.precio);
            Console.WriteLine("Stock: " + producto1.stock);
            Console.WriteLine("Disponible: " + producto1.disponible);

            Console.WriteLine("");

            // Crear segundo objeto de tipo Producto
            Producto producto2 = new Producto();

            producto2.codigo = "PRD002";
            producto2.nombre = "Monitor 24 pulgadas";
            producto2.precio = 199.99;
            producto2.stock = 8;
            producto2.disponible = true;

            Console.WriteLine("Producto 2:");
            Console.WriteLine("Código: " + producto2.codigo);
            Console.WriteLine("Nombre: " + producto2.nombre);
            Console.WriteLine("Precio: " + producto2.precio);
            Console.WriteLine("Stock: " + producto2.stock);
            Console.WriteLine("Disponible: " + producto2.disponible);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        // ==================== EJERCICIO 4 ====================
        static void Ejercicio4()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 4: CLASE MASCOTA ===\n");

            // Crear objeto de tipo Mascota
            Mascota mascota1 = new Mascota();

            // Asignar valores a los atributos
            mascota1.nombre = "Luna";
            mascota1.especie = "Gato";
            mascota1.edad = 2;
            mascota1.peso = 4.5;
            mascota1.vacunado = true;

            // Mostrar los datos
            Console.WriteLine("Información de la Mascota:");
            Console.WriteLine("Nombre: " + mascota1.nombre);
            Console.WriteLine("Especie: " + mascota1.especie);
            Console.WriteLine("Edad: " + mascota1.edad);
            Console.WriteLine("Peso: " + mascota1.peso);
            Console.WriteLine("Vacunado: " + mascota1.vacunado);

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }
    }
}