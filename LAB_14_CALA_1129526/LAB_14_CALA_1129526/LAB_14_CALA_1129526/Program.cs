using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_CALA_1129526
{
    internal class Program
    {
        // ==================== CLASE LIBRO ====================
        class Libro
        {
            private string titulo;
            private string autor;
            private int anioPublicacion;
            private bool disponible;

            // Constructor
            public Libro(string titulo, string autor, int anioPublicacion, bool disponible)
            {
                this.titulo = titulo;
                this.autor = autor;
                this.anioPublicacion = anioPublicacion;
                this.disponible = disponible;
            }

            // Metodos Get
            public string GetTitulo() { return titulo; }
            public string GetAutor() { return autor; }
            public int GetAnioPublicacion() { return anioPublicacion; }
            public bool GetDisponible() { return disponible; }

            // Metodos Set
            public void SetTitulo(string titulo) { this.titulo = titulo; }
            public void SetAutor(string autor) { this.autor = autor; }
            public void SetAnioPublicacion(int anioPublicacion) { this.anioPublicacion = anioPublicacion; }
            public void SetDisponible(bool disponible) { this.disponible = disponible; }

            // Muestra la informacion completa del libro
            public void MostrarInformacion()
            {
                string estado;
                if (disponible == true)
                    estado = "Si";
                else
                    estado = "No";

                Console.WriteLine("Titulo: " + titulo);
                Console.WriteLine("Autor: " + autor);
                Console.WriteLine("Anio de publicacion: " + anioPublicacion);
                Console.WriteLine("Disponible: " + estado);
            }

            // Presta el libro si esta disponible
            public void PrestarLibro()
            {
                if (disponible == true)
                {
                    disponible = false;
                    Console.WriteLine("El libro \"" + titulo + "\" ha sido prestado.");
                }
                else
                {
                    Console.WriteLine("El libro \"" + titulo + "\" no esta disponible.");
                }
            }

            // Devuelve el libro y lo marca como disponible
            public void DevolverLibro()
            {
                disponible = true;
                Console.WriteLine("El libro \"" + titulo + "\" ha sido devuelto.");
            }
        }

        // ==================== CLASE MASCOTA ====================
        class Mascota
        {
            private string nombre;
            private string especie;
            private int edad;
            private bool vacunado;

            // Constructor
            public Mascota(string nombre, string especie, int edad, bool vacunado)
            {
                this.nombre = nombre;
                this.especie = especie;
                this.edad = edad;
                this.vacunado = vacunado;
            }

            // Metodos Get
            public string GetNombre() { return nombre; }
            public string GetEspecie() { return especie; }
            public int GetEdad() { return edad; }
            public bool GetVacunado() { return vacunado; }

            // Metodos Set
            public void SetNombre(string nombre) { this.nombre = nombre; }
            public void SetEspecie(string especie) { this.especie = especie; }
            public void SetEdad(int edad) { this.edad = edad; }
            public void SetVacunado(bool vacunado) { this.vacunado = vacunado; }

            // Muestra la informacion completa de la mascota
            public void MostrarInformacion()
            {
                string estado;
                if (vacunado == true)
                    estado = "Si";
                else
                    estado = "No";

                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Especie: " + especie);
                Console.WriteLine("Edad: " + edad + " anios");
                Console.WriteLine("Vacunado: " + estado);
            }

            // Cambia el estado de vacunacion a verdadero
            public void Vacunar()
            {
                vacunado = true;
                Console.WriteLine(nombre + " ha sido vacunado.");
            }

            // Aumenta la edad de la mascota en 1
            public void CumplirAnios()
            {
                edad = edad + 1;
                Console.WriteLine(nombre + " ahora tiene " + edad + " anios.");
            }
        }

        // ==================== CLASE ESTUDIANTE ====================
        class Estudiante
        {
            private string nombre;
            private int edad;
            private string grado;
            private double[] notas;
            private int cantidadNotas;

            // Constructor
            public Estudiante(string nombre, int edad, string grado, double[] notas)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.grado = grado;
                this.cantidadNotas = notas.Length;
                this.notas = new double[cantidadNotas + 20];
                for (int i = 0; i < cantidadNotas; i++)
                {
                    this.notas[i] = notas[i];
                }
            }

            // Metodos Get
            public string GetNombre() { return nombre; }
            public int GetEdad() { return edad; }
            public string GetGrado() { return grado; }

            // Metodos Set
            public void SetNombre(string nombre) { this.nombre = nombre; }
            public void SetEdad(int edad) { this.edad = edad; }
            public void SetGrado(string grado) { this.grado = grado; }

            // Calcula el promedio de las notas del estudiante
            public double CalcularPromedio()
            {
                double suma = 0;
                for (int i = 0; i < cantidadNotas; i++)
                {
                    suma = suma + notas[i];
                }
                double promedio = suma / cantidadNotas;
                return promedio;
            }

            // Muestra toda la informacion del estudiante
            public void MostrarInformacion()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("Grado: " + grado);
                Console.Write("Notas: ");
                for (int i = 0; i < cantidadNotas; i++)
                {
                    if (i < cantidadNotas - 1)
                        Console.Write(notas[i] + ", ");
                    else
                        Console.Write(notas[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Promedio: " + CalcularPromedio());
            }

            // Indica si el estudiante aprobo segun su promedio
            public void Aprobar()
            {
                double promedio = CalcularPromedio();
                if (promedio >= 61)
                    Console.WriteLine(nombre + " aprobo con un promedio de " + promedio);
                else
                    Console.WriteLine(nombre + " no aprobo. Promedio: " + promedio);
            }

            // Agrega una nueva nota al arreglo y recalcula el promedio
            public void AgregarNota(double nuevaNota)
            {
                notas[cantidadNotas] = nuevaNota;
                cantidadNotas = cantidadNotas + 1;
                Console.WriteLine("Nota " + nuevaNota + " agregada. Nuevo promedio: " + CalcularPromedio());
            }
        }

        // ==================== MAIN ====================
        static void Main()
        {
            Console.Write("Como te llamas? ");
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine("Hola, " + nombreUsuario + " Bienvenido al Laboratorio 14!");

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("=== LABORATORIO 14: PROGRAMACION ORIENTADA A OBJETOS ===\n");

            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
        }

        // ==================== EJERCICIO 1 ====================
        static void Ejercicio1()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 1: CLASE LIBRO ===\n");

            // Crear dos objetos de tipo Libro
            Libro libro1 = new Libro("Cien Anos de Soledad", "Gabriel Garcia Marquez", 1967, true);
            Libro libro2 = new Libro("El Principito", "Antoine de Saint-Exupery", 1943, true);

            // Mostrar informacion de ambos libros
            Console.WriteLine("--- Libro 1 ---");
            libro1.MostrarInformacion();

            Console.WriteLine("\n--- Libro 2 ---");
            libro2.MostrarInformacion();

            // Probar prestamo del libro1
            Console.WriteLine("\n--- Prestamo de libro 1 ---");
            Console.WriteLine("Estado antes del prestamo:");
            libro1.MostrarInformacion();
            libro1.PrestarLibro();
            Console.WriteLine("Estado despues del prestamo:");
            libro1.MostrarInformacion();

            // Intentar prestar el libro1 de nuevo (ya no esta disponible)
            Console.WriteLine("\nIntento de prestamo nuevamente:");
            libro1.PrestarLibro();

            // Devolver el libro1
            Console.WriteLine("\n--- Devolucion de libro 1 ---");
            libro1.DevolverLibro();
            Console.WriteLine("Estado despues de la devolucion:");
            libro1.MostrarInformacion();

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        // ==================== EJERCICIO 2 ====================
        static void Ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 2: CLASE MASCOTA ===\n");

            // Crear dos objetos de tipo Mascota
            Mascota mascota1 = new Mascota("Rex", "Perro", 3, false);
            Mascota mascota2 = new Mascota("Mimi", "Gato", 1, true);

            // Mostrar informacion de ambas mascotas
            Console.WriteLine("--- Mascota 1 ---");
            mascota1.MostrarInformacion();

            Console.WriteLine("\n--- Mascota 2 ---");
            mascota2.MostrarInformacion();

            // Vacunar mascota1 y mostrar el cambio
            Console.WriteLine("\n--- Vacunacion de mascota 1 ---");
            Console.WriteLine("Estado antes de vacunar:");
            mascota1.MostrarInformacion();
            mascota1.Vacunar();
            Console.WriteLine("Estado despues de vacunar:");
            mascota1.MostrarInformacion();

            // Incrementar edad de mascota2 y mostrar resultado
            Console.WriteLine("\n--- Cumpleanos de mascota 2 ---");
            Console.WriteLine("Edad antes:");
            mascota2.MostrarInformacion();
            mascota2.CumplirAnios();
            Console.WriteLine("Edad despues:");
            mascota2.MostrarInformacion();

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        // ==================== EJERCICIO 3 ====================
        static void Ejercicio3()
        {
            Console.Clear();
            Console.WriteLine("=== EJERCICIO 3: CLASE ESTUDIANTE ===\n");

            // Crear dos objetos de tipo Estudiante con arreglos de notas
            double[] notasEstudiante1 = { 75, 80, 90, 65, 70 };
            double[] notasEstudiante2 = { 50, 45, 55, 60, 40 };

            Estudiante estudiante1 = new Estudiante("Maria Lopez", 17, "3ro Bachillerato", notasEstudiante1);
            Estudiante estudiante2 = new Estudiante("Pedro Ramirez", 16, "2do Bachillerato", notasEstudiante2);

            // Mostrar informacion y promedio de ambos estudiantes
            Console.WriteLine("--- Estudiante 1 ---");
            estudiante1.MostrarInformacion();

            Console.WriteLine("\n--- Estudiante 2 ---");
            estudiante2.MostrarInformacion();

            // Verificar si aprobaron
            Console.WriteLine("\n--- Resultado de aprobacion ---");
            estudiante1.Aprobar();
            estudiante2.Aprobar();

            // Agregar una nueva nota al estudiante2 y mostrar resultado actualizado
            Console.WriteLine("\n--- Agregar nota a estudiante 2 ---");
            Console.WriteLine("Informacion antes de agregar nota:");
            estudiante2.MostrarInformacion();
            estudiante2.AgregarNota(85);
            Console.WriteLine("Informacion despues de agregar nota:");
            estudiante2.MostrarInformacion();
            estudiante2.Aprobar();

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }
    }
}