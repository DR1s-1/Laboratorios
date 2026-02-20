using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lab 5 Ejercicio 1 Panel de Acceso Numérico (Usuario + PIN + Modo seguro)
            int Usuario, PIN, Token;
            string modo;

            Console.WriteLine("");
            Console.WriteLine("Ejercicio #1 panel de acceso numerico");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el número de usuario: ");
            Usuario = int.Parse(Console.ReadLine());

            if (Usuario == 2026)
            {
                Console.WriteLine("Usuario encontrado");

            }
            else
            {
                Console.WriteLine("Usuario no encontrado");
            }

            Console.WriteLine("Ingrese el número de PIN: ");
            PIN = int.Parse(Console.ReadLine());

            if (PIN == 1234)
            {
                Console.WriteLine("PIN correcto");
            }
            else
            {
                Console.WriteLine("PIN incorrecto");
            }

            Console.WriteLine("Ingrese el número de Token: ");
            Token = int.Parse(Console.ReadLine());

            if (Token == 777)
            {
                Console.WriteLine("Token correcto");
            }
            else
            {
                Console.WriteLine("Token incorrecto");
            }

            Console.WriteLine(" Modo seguro? escriba si o no: ");
            modo = Console.ReadLine();

            if (modo.ToLower() == "si")
            {
                Console.WriteLine("Modo seguro activado");
            }
            else
            {
                Console.WriteLine("Modo seguro no activo");

            }

            if (Usuario == 2026 && PIN == 1234 && Token == 777 && modo.ToLower() == "si")
            {
                Console.WriteLine("Acceso Total concedido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }

            if (modo == "si")
            {
                if (Token >= 700)
                {
                    Console.WriteLine("Regla Extra Aprobada");
                }
                else
                {
                    Console.WriteLine("Regla Extra Fallida");
                }
            }

            else
            {
                Console.WriteLine("Modo Seguro Desactivado");
            }


            // Ejercicio 2

            Console.WriteLine("");
            Console.WriteLine("Ejercicio #2 Validación de PIN de Seguridad");
            Console.WriteLine("");

            int Pin_2;

            Console.WriteLine("Ingrese Pin de Seguridad");
            Pin_2 = int.Parse(Console.ReadLine());

            if (Pin_2 > 1000 && Pin_2 < 9999)
            {
                Console.WriteLine("PIN de 4 digitos OK");

            }

            else
            {
                Console.WriteLine("Pin Invalido: debe tener 4 digitos");
            }

            if (Pin_2 % 2 == 0)
            {
                Console.WriteLine("Numero par");

                if (Pin_2 % 5 == 0)
                {
                    Console.WriteLine("Numero Multiplo de 5");
                }
                else
                {
                    Console.WriteLine("Numero no es multiplo de 5");
                }

            }

            else
            {
                Console.WriteLine("Numero Impar");
            }

            if (Pin_2 > 1000 && Pin_2 < 9999 && Pin_2 % 2 == 0 && Pin_2 % 5 != 0)
            {
                Console.WriteLine(" PIN aceptado por politica");

            }
            else
            {
                Console.WriteLine("PIN rechazado por Politica");
            }

            // Ejercicio 3

            Console.WriteLine("");
            Console.WriteLine("Ejercicio #3 Activación de Cuenta");
            Console.WriteLine("");

            int codigo, edad, points;
            string Fa2, terms;

            Console.WriteLine("Ingrese el código de activacion: ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Acepto Terminos y Condiciones?");
            terms = Console.ReadLine();

            Console.WriteLine("¿Activo Verificacion en 2 pasos?");
            Fa2 = Console.ReadLine();

            Console.WriteLine("Ingrese su cantidad de puntaje: ");
            points = int.Parse(Console.ReadLine());

            if (codigo == 2026)

            {
                Console.WriteLine("Codigo correcto");
            }

            else
            {
                Console.WriteLine("Codigo incorrecto");
            }

            if (edad >= 18)
            {
                Console.WriteLine("Edad Válida");
            }
            else
            {
                Console.WriteLine("Edad no Válida");
            }

            if (terms.ToLower() == "si")
            {
                Console.WriteLine("Terminos y Condiciones Aceptados");
            }
            else
            {
                Console.WriteLine("Debe aceptar Terminos y Condiciones");
            }

            if (Fa2.ToLower() == "si")
            {
                Console.WriteLine("2FA Activado");
            }
            else
            {
                Console.WriteLine("2FA No Activado");
            }

            if (points >= 1000)
            {
                Console.WriteLine("Puntaje Suficiente");
            }
            else
            {
                Console.WriteLine("Puntaje Insuficiente");
            }

            if (codigo == 2026 && edad >= 18 && terms.ToLower() == "si" && Fa2.ToLower() == "si" && points >= 70)
            {
                Console.WriteLine("Cuenta Activada exitosamente");
            }
            else
            {
                Console.WriteLine("Cuenta No Activada");

            }

            // Ejercicio 4 Requisito para examen final

            Console.WriteLine("");
            Console.WriteLine("Ejercicio #4 Requisitos para Examen Final");
            Console.WriteLine("");

            int NotaP, MinT;
            string Sol, DPI, Calcu;

            Console.WriteLine("Ingrese su nota previa: ");
            NotaP = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Los minutos de llegada Tarde");
            MinT = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Tiene Solvencia de pagos ");
            Sol = Console.ReadLine();

            Console.WriteLine("¿Trae Consigo DPI en Fisico? ");
            DPI = Console.ReadLine();

            Console.WriteLine("¿Trae Calculadora Permitida? ");
            Calcu = Console.ReadLine();

            

            if (NotaP >= 61)
            {
                Console.WriteLine("Requisito Academico Aprobado");
            }
            else
            {
                Console.WriteLine("Requisito Academico No Aprobado");
            }

            if (MinT <= 10)
            {
                Console.WriteLine("Requisito de Puntualidad Aprobado");
            }
            else
            {
                Console.WriteLine("Requisito de Puntualidad No Aprobado");
            }

            if (Sol.ToLower() == "si")
            {
                Console.WriteLine("Requisito de Solvencia Aprobado");
            }
            else
            {
                Console.WriteLine("Requisito de Solvencia No Aprobado");
            }

            if (DPI.ToLower() == "si")
            {
                Console.WriteLine("Requisito de DPI Aprobado");
            }
            else
            {
                Console.WriteLine("Requisito de DPI No Aprobado");
            }

            if (Calcu.ToLower() == "si")
            {
                Console.WriteLine("Requisito de Calculadora Aprobado");
            }
            else
            {
                Console.WriteLine("Requisito de Calculadora No Aprobado");
            }

            if (NotaP >= 61 && MinT <= 10 && Sol.ToLower() == "si" && DPI.ToLower() == "si" && Calcu.ToLower() == "si")
            {
                Console.WriteLine("Acceso a sala de Examen Final");
            }
            else
            {
                Console.WriteLine("No Puede ingresar a la sala del Examen Final");

            }
            if (MinT > 0 && MinT <= 10)
            {
                Console.WriteLine("Advertencia: Llegada Tarde, Pero aun Puede Ingresar");
            }
            else if (MinT > 10)
            {
                Console.WriteLine("Llegada Tarde No Permitida");

            }

            // Destino Sentimental 

            Console.WriteLine("");
            Console.WriteLine("Ejercicio #5 Destino Sentimental");
            Console.WriteLine("");

            string Nombre_Enamorada, LikeProgramacion, Memes, estado;
            int interes, valentia;

            Console.WriteLine("Ingrese el interes hacia esa persona:  1 - 100 ");
            interes = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre de su enamorada");
            Nombre_Enamorada = Console.ReadLine();

            Console.WriteLine("¿cuanta valentia teiene para declararse? 1 - 100 ");
            valentia = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Estado Sentimental? ");
            estado = Console.ReadLine();

            Console.WriteLine("¿Le gustan la Programación? ");
            LikeProgramacion = Console.ReadLine();

            Console.WriteLine("¿Le gustan los Memes? ");
            Memes = Console.ReadLine();


            if (interes >= 70)
            {
                Console.WriteLine("Interes Alto Detectado");
            }
            else
            {
                Console.WriteLine("Interes Insuficiente. Riesgo de Friend Zone Elevado");
            }

            if (valentia >= 70)
            {
                Console.WriteLine("Valentia Favorable, Confia en ti Mismo");
            }
            else
            {
                Console.WriteLine("Nivel de Valentia Bajo, Actualización de hardware requerida (Vaya al GYM)");
            }
            if (estado.ToLower() == "soltera")
            {
                Console.WriteLine("Estado Sentimental favorable, aunque lo esté, no le crea: Todas Absolutamente todas las Damas mienten");
            }
            else
            {
                Console.WriteLine("Estado Sentimental Comprometido, no es recomendable hackear esa relacion");
            }
            if (LikeProgramacion.ToLower() == "si" && Memes.ToLower() == "si")
            {
                Console.WriteLine("Compatibilidad Geek Detectada");
            }
            else
            {
                Console.WriteLine("Compatibilidad parcial o inexistente, no conviene el riesgo");
            }
            if (interes >= 70 && valentia >= 70 && estado.ToLower() == "soltera" && LikeProgramacion.ToLower() == "si" && Memes.ToLower() == "si")
            {
                Console.WriteLine("Destino Sentimental Favorable, proceder con Chocolates y rosas");

            }
                if (interes >= 70 && valentia < 70 && estado.ToLower() == "soltera" && LikeProgramacion.ToLower() == "si" && Memes.ToLower() == "si")

                {
                    Console.WriteLine("No le tenga miedo al éxito que vida solo hay 1");
                }

                else
                {
                    Console.WriteLine(Nombre_Enamorada + " no te ama... por ahora jijiji");
                }

            

        }
    }
}