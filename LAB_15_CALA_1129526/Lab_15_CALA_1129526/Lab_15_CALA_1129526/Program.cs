using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15_CALA_1129526
{
    internal class Program
    {
        // ==================== MAIN ====================
        static void Main()
        {
            Console.Write("Como te llamas? ");
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine("Hola, " + nombreUsuario + " Bienvenido al Laboratorio 15!");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("=== LABORATORIO 15: CONTROL DE CALIDAD Y DEPURACION ===\n");

            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
        }

        // ==================== EJERCICIO 1 ====================
        static void Ejercicio1()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 1 ---");
            Console.WriteLine("Identificacion y correccion de errores de sintaxis\n");

            /*
             * CODIGO ORIGINAL CON ERRORES:
             *
             * using System          <-- Error 1: falta punto y coma al final
             * class Program
             * {
             *     static void Main()
             *     {
             *         string nombre  <-- Error 2: falta punto y coma en la declaracion
             *         int edad;
             *         Console.WriteLine("Ingrese su nombre:");
             *         nombre = Console.ReadLine();
             *         Console.WriteLine("Ingrese su edad:");
             *         edad = int.Parse(Console.ReadLine())  <-- Error 3: falta punto y coma
             *         Console.WriteLine("Hola " + nombre);
             *         Console.WriteLine("Tienes " + edad + " anos");
             *         if (edad >= 18)
             *         {
             *             Console.WriteLine("Eres mayor de edad");
             *      else                       <-- Error 4: falta cerrar la llave del if antes del else
             *             {
             *                 Console.WriteLine("Eres menor de edad");
             *             }
             *         }
             *     }
             * }
             */

            // Error encontrado: falta ";" despues de "using System"
            // Tipo de error: sintaxis
            // Correccion realizada: se agrego el punto y coma
            // Explicacion: en C# toda directiva using debe terminar con punto y coma

            // Error encontrado: falta ";" en la declaracion "string nombre"
            // Tipo de error: sintaxis
            // Correccion realizada: se agrego punto y coma al final de la linea
            // Explicacion: toda declaracion de variable debe terminar con punto y coma

            // Error encontrado: falta ";" al final de "edad = int.Parse(Console.ReadLine())"
            // Tipo de error: sintaxis
            // Correccion realizada: se agrego punto y coma al final de la instruccion
            // Explicacion: toda instruccion en C# debe terminar con punto y coma

            // Error encontrado: falta la llave de cierre "}" del bloque if antes del else
            // Tipo de error: sintaxis
            // Correccion realizada: se agrego la llave de cierre correctamente
            // Explicacion: cada bloque if debe cerrar con "}" antes de escribir el else

            string nombre;
            int edad;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Tienes " + edad + " anos");

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }

            /*
             * PRUEBAS REALIZADAS:
             * Prueba 1: nombre = "Carlos", edad = 20 -> Resultado: "Eres mayor de edad" (correcto)
             * Prueba 2: nombre = "Ana",    edad = 15 -> Resultado: "Eres menor de edad" (correcto)
             */

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        // ==================== EJERCICIO 2 ====================
        static void Ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 2 ---");
            Console.WriteLine("Correccion de errores logicos\n");

            /*
             * CODIGO ORIGINAL CON ERRORES:
             *
             *     promedio = nota1 + nota2 + nota3 / 3;
             *                                          ^-- Error logico 1:
             *     Por precedencia de operadores, solo nota3 se divide entre 3.
             *     El resultado real seria: nota1 + nota2 + (nota3 / 3)
             *     Con notas 60, 60, 60: el resultado seria 60 + 60 + 20 = 140, no 60.
             *
             *     if (promedio > 61)
             *                  ^-- Error logico 2:
             *     La condicion usa ">" en lugar de ">=".
             *     Con promedio exactamente 61, el estudiante deberia aprobar, pero el
             *     programa indicaria que reprobo.
             */

            // Error encontrado: formula del promedio sin parentesis
            // Tipo de error: logico
            // Correccion realizada: se envolvio la suma en parentesis: (nota1 + nota2 + nota3) / 3
            // Explicacion: sin parentesis, la division se aplica solo a nota3 por precedencia de operadores

            // Error encontrado: condicion de aprobacion usa ">" en lugar de ">="
            // Tipo de error: logico
            // Correccion realizada: se cambio "promedio > 61" por "promedio >= 61"
            // Explicacion: el enunciado dice que 61 tambien aprueba, por lo que se necesita >=

            double nota1, nota2, nota3, promedio;

            Console.WriteLine("Ingrese la primera nota:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota:");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la tercera nota:");
            nota3 = double.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio es: " + promedio);

            if (promedio >= 61)
            {
                Console.WriteLine("El estudiante aprobo");
            }
            else
            {
                Console.WriteLine("El estudiante reprobo");
            }

            /*
             * PRUEBAS REALIZADAS:
             * Prueba 1: 60, 60, 60  -> Promedio: 60   -> Resultado: reprobo   (correcto)
             * Prueba 2: 61, 61, 61  -> Promedio: 61   -> Resultado: aprobo    (correcto)
             * Prueba 3: 80, 70, 90  -> Promedio: 80   -> Resultado: aprobo    (correcto)
             */

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        // ==================== EJERCICIO 3 ====================
        static void Ejercicio3()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 3 ---");
            Console.WriteLine("Identificacion de errores de ejecucion en arreglos\n");

            /*
             * CODIGO ORIGINAL CON ERRORES:
             *
             *     int[] numeros = new int[5];
             *
             *     for (int i = 0; i <= 5; i++)   <-- Error de ejecucion:
             *     {                                   el arreglo tiene posiciones 0,1,2,3,4
             *         numeros[i] = ...;               cuando i llega a 5 no existe esa posicion
             *     }                                   y se lanza IndexOutOfRangeException
             *
             *     for (int i = 0; i <= 5; i++)   <-- mismo error en el segundo ciclo
             *     {
             *         suma = suma + numeros[i];
             *     }
             *
             * EXPLICACION:
             * Un arreglo declarado como new int[5] reserva exactamente 5 espacios,
             * con indices del 0 al 4. Intentar acceder a numeros[5] provoca un error
             * de ejecucion (IndexOutOfRangeException) porque esa posicion no existe.
             */

            // Error encontrado: ciclo usa "i <= 5" permitiendo acceder a posicion 5 (inexistente)
            // Tipo de error: ejecucion
            // Correccion realizada: se cambio "i <= 5" por "i < 5" en ambos ciclos
            // Explicacion: con i < 5 el ciclo recorre solo las posiciones 0, 1, 2, 3 y 4

            int[] numeros = new int[5];
            int suma = 0;

            for (int i = 0; i < 5; i++)
            {
                int numero;
                bool valido = false;

                while (!valido)
                {
                    Console.WriteLine("Ingrese el numero " + (i + 1) + ":");
                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        numeros[i] = numero;
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida. Intente de nuevo.");
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                suma = suma + numeros[i];
            }

            Console.WriteLine("La suma total es: " + suma);

            /*
             * PRUEBAS REALIZADAS:
             * Prueba 1: 1, 2, 3, 4, 5     -> Suma: 15      (correcto)
             * Prueba 2: "hola" ingresado   -> Pide de nuevo (correcto, no se cierra el programa)
             */

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        // ==================== EJERCICIO 4 ====================
        static void Ejercicio4()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 4 ---");
            Console.WriteLine("Depuracion de un programa con metodos\n");

            /*
             * CODIGO ORIGINAL CON ERRORES:
             *
             *     static double CalcularArea(double baseRectangulo, double alturaRectangulo)
             *     {
             *         double resultado = baseRectangulo + alturaRectangulo;  <-- Error logico:
             *         return resultado;                                           usa suma en vez de multiplicacion
             *     }
             *
             *     if (area > 100)   <-- Error logico: deberia ser >= 100 para que 100 sea "grande"
             *
             * Ademas falta validacion de entradas negativas o cero, y validacion si el usuario
             * escribe texto en lugar de un numero.
             */

            // Error encontrado: CalcularArea suma base + altura en lugar de multiplicarlas
            // Tipo de error: logico
            // Correccion realizada: se cambio "+" por "*" en la operacion
            // Explicacion: el area de un rectangulo es base multiplicada por altura, no su suma

            // Error encontrado: la condicion es "area > 100" excluyendo el caso exacto de 100
            // Tipo de error: logico
            // Correccion realizada: se cambio ">" por ">=" en la condicion
            // Explicacion: segun el enunciado, un area de exactamente 100 debe clasificarse como grande

            double baseRectangulo = 0;
            double alturaRectangulo = 0;
            bool baseValida = false;
            bool alturaValida = false;

            while (!baseValida)
            {
                Console.WriteLine("Ingrese la base del rectangulo:");
                if (double.TryParse(Console.ReadLine(), out baseRectangulo))
                {
                    if (baseRectangulo > 0)
                    {
                        baseValida = true;
                    }
                    else
                    {
                        Console.WriteLine("La base debe ser mayor que cero. Intente de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Ingrese un numero.");
                }
            }

            while (!alturaValida)
            {
                Console.WriteLine("Ingrese la altura del rectangulo:");
                if (double.TryParse(Console.ReadLine(), out alturaRectangulo))
                {
                    if (alturaRectangulo > 0)
                    {
                        alturaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("La altura debe ser mayor que cero. Intente de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Ingrese un numero.");
                }
            }

            double area = CalcularArea(baseRectangulo, alturaRectangulo);

            Console.WriteLine("Base ingresada: " + baseRectangulo);
            Console.WriteLine("Altura ingresada: " + alturaRectangulo);
            Console.WriteLine("Area calculada: " + area);

            if (area >= 100)
            {
                Console.WriteLine("El area es grande");
            }
            else
            {
                Console.WriteLine("El area es pequena");
            }

            /*
             * PRUEBAS REALIZADAS:
             * Prueba 1: base=10, altura=10  -> Area: 100 -> Grande  (correcto)
             * Prueba 2: base=5,  altura=8   -> Area: 40  -> Pequena (correcto)
             * Prueba 3: base=20, altura=6   -> Area: 120 -> Grande  (correcto)
             * Prueba 4: base=-5, altura=8   -> Pide valor valido    (correcto)
             */

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }

        // Metodo que calcula el area de un rectangulo
        static double CalcularArea(double baseRectangulo, double alturaRectangulo)
        {
            // Error encontrado: usaba suma en lugar de multiplicacion
            // Tipo de error: logico
            // Correccion realizada: se cambio "+" por "*"
            // Explicacion: area = base * altura, no base + altura
            double resultado = baseRectangulo * alturaRectangulo;
            return resultado;
        }

        // ==================== EJERCICIO 5 ====================
        static void Ejercicio5()
        {
            Console.Clear();
            Console.WriteLine("--- Ejercicio 5 ---");
            Console.WriteLine("Analisis de solucion generada por Inteligencia Artificial\n");

            // Analisis de la solucion generada por IA:
            // Error 1: el ciclo comienza en i = 1 en lugar de i = 0, causando que edades[1]
            //          sea el primer elemento guardado y edades[0] quede vacio. Ademas cuando
            //          i llega a 5 se intenta acceder a edades[5] que no existe, lo que lanza
            //          un IndexOutOfRangeException.
            // Error 2: la condicion para contar mayores de edad usa "edades[i] > 18" en lugar
            //          de "edades[i] >= 18", por lo que una persona de exactamente 18 anos
            //          no se contaria como mayor de edad siendo que si lo es.
            // Error 3: el promedio se calcula como "suma / 5" siendo suma un entero, lo que
            //          provoca division entera y pierde los decimales. Con edades 10,15,18,20,30
            //          el resultado seria 18 en lugar de 18.6.
            // Limitacion encontrada: el codigo generado por la IA no incluye ninguna validacion
            //          de entrada. Si el usuario escribe texto o una edad negativa, el programa
            //          falla o acepta datos sin sentido.
            // Importancia de la validacion humana: la IA genera codigo funcional en apariencia
            //          pero con errores sutiles que solo se detectan probando o revisando
            //          cuidadosamente. El programador humano es responsable de verificar que
            //          la logica sea correcta y que el programa sea robusto ante entradas invalidas.

            int[] edades = new int[5];
            int suma = 0;
            int mayores = 0;
            double promedio;

            for (int i = 0; i < 5; i++)
            {
                bool valido = false;
                int edad = 0;

                while (!valido)
                {
                    Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");
                    if (int.TryParse(Console.ReadLine(), out edad))
                    {
                        if (edad >= 0)
                        {
                            valido = true;
                        }
                        else
                        {
                            Console.WriteLine("La edad no puede ser negativa. Intente de nuevo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada invalida. Ingrese un numero entero.");
                    }
                }

                edades[i] = edad;
                suma = suma + edades[i];

                if (edades[i] >= 18)
                {
                    mayores = mayores + 1;
                }
            }

            promedio = (double)suma / 5;

            Console.WriteLine("El promedio de edades es: " + promedio);
            Console.WriteLine("Cantidad de mayores de edad: " + mayores);

            /*
             * PRUEBAS REALIZADAS:
             * Prueba 1: 10, 15, 18, 20, 30  -> Promedio: 18.6  -> Mayores: 3  (correcto)
             * Prueba 2: 18, 18, 18, 18, 18  -> Promedio: 18    -> Mayores: 5  (correcto)
             * Prueba 3: 5, 6, 7, 8, 9       -> Promedio: 7     -> Mayores: 0  (correcto)
             * Prueba 4: texto o edad negativa -> no acepta dato, pide de nuevo (correcto)
             */

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadLine();
        }
    }
}

// ==================== PREGUNTA FINAL DE REFLEXION ====================
// Por que una solucion generada por Inteligencia Artificial debe ser revisada,
// probada y validada por una persona antes de considerarse correcta?
//
// Respuesta:
// Una herramienta de Inteligencia Artificial genera codigo basandose en patrones
// aprendidos, pero no comprende el problema de la misma forma que un programador humano.
// Esto significa que puede producir errores sutiles de logica, como condiciones incorrectas
// o formulas mal escritas, que no impiden que el programa compile pero si generan resultados
// erroneos. Ademas, la IA frecuentemente omite validaciones importantes como manejo de
// entradas invalidas, valores negativos o casos extremos, lo que hace que el programa sea
// fragil en uso real. El programador humano conoce el contexto del problema, puede hacer
// pruebas con datos reales y detectar si el resultado tiene sentido. Por eso, confiar
// ciegamente en el codigo generado por IA sin revisarlo es un riesgo: el codigo puede
// parecer correcto a simple vista y aun asi fallar cuando se ejecuta con datos reales.
// La validacion humana es indispensable para garantizar que el programa sea correcto,
// seguro y util para quien lo va a utilizar.