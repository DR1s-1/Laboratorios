using System;

namespace Proyecto2_Granja
{
    // ==================== CLASE PARCELA ====================
    // Representa una seccion de la cuadricula de la granja
    class Parcela
    {
        // Atributos de la parcela
        public string TipoCultivo;    // "Vacia", "Papa", "Tomate", "Fresa"
        public int MesesCrecimiento;  // Meses que lleva creciendo
        public int MesesNecesarios;   // Meses que necesita para cosechar
        public int IngresosCosecha;   // Dinero que genera al cosechar
        public bool RegadaEsteMes;    // Si ya fue regada en el mes actual

        // Constructor: toda parcela comienza vacia
        public Parcela()
        {
            TipoCultivo = "Vacia";
            MesesCrecimiento = 0;
            MesesNecesarios = 0;
            IngresosCosecha = 0;
            RegadaEsteMes = false;
        }

        // Metodo para sembrar un tipo de cultivo en la parcela
        public void Sembrar(string tipo)
        {
            TipoCultivo = tipo;
            MesesCrecimiento = 0;
            RegadaEsteMes = false;

            if (tipo == "Papa")
            {
                MesesNecesarios = 2;
                IngresosCosecha = 450;
            }
            else if (tipo == "Tomate")
            {
                MesesNecesarios = 3;
                IngresosCosecha = 650;
            }
            else if (tipo == "Fresa")
            {
                MesesNecesarios = 4;
                IngresosCosecha = 900;
            }
        }

        // Metodo para vaciar la parcela despues de cosechar
        public void Vaciar()
        {
            TipoCultivo = "Vacia";
            MesesCrecimiento = 0;
            MesesNecesarios = 0;
            IngresosCosecha = 0;
            RegadaEsteMes = false;
        }
    }

    // ==================== CLASE GRANJA ====================
    // Administra toda la logica de la granja
    class Granja
    {
        // Atributos de configuracion
        public double Dinero;
        public int NumeroEmpleados;
        public double SueldoPorEmpleado;
        public int MesesRestantes;
        public int Filas;
        public int Columnas;

        // Matriz de parcelas
        public Parcela[,] Parcelas;

        // Contadores para el reporte final
        public double TotalIngresos;
        public double TotalEgresos;
        public int MesesSimulados;
        public int ContadorPapasSembradas;
        public int ContadorTomatesSembrados;
        public int ContadorFresasSembradas;
        public int ContadorCosechasPapa;
        public int ContadorCosechasTomate;
        public int ContadorCosechasFresa;
        public int ContadorRiegos;

        // Constructor: inicializa la granja con los datos del usuario
        public Granja(double dinero, int empleados, double sueldo, int meses, int filas, int columnas)
        {
            Dinero = dinero;
            NumeroEmpleados = empleados;
            SueldoPorEmpleado = sueldo;
            MesesRestantes = meses;
            Filas = filas;
            Columnas = columnas;

            // Inicializar matriz de parcelas
            Parcelas = new Parcela[filas, columnas];
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Parcelas[f, c] = new Parcela();
                }
            }

            // Inicializar contadores
            TotalIngresos = 0;
            TotalEgresos = 0;
            MesesSimulados = 0;
            ContadorPapasSembradas = 0;
            ContadorTomatesSembrados = 0;
            ContadorFresasSembradas = 0;
            ContadorCosechasPapa = 0;
            ContadorCosechasTomate = 0;
            ContadorCosechasFresa = 0;
            ContadorRiegos = 0;
        }
    }

    // ==================== CLASE PROGRAM ====================
    internal class Program
    {
        // Variable global de la granja
        static Granja granja;

        // ==================== MAIN ====================
        static void Main()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("   PROYECTO 2 - GESTION DE GRANJA POR CONSOLA  ");
            Console.WriteLine("================================================");
            Console.WriteLine();

            // Configuracion inicial
            ConfigurarGranja();

            // Ciclo principal: continua mientras haya meses y dinero
            bool continuar = true;
            while (continuar)
            {
                // Verificar condiciones de fin de simulacion
                if (granja.MesesRestantes <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** Se agotaron los meses de simulacion. ***");
                    continuar = false;
                    break;
                }

                if (granja.Dinero <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("*** Se acabo el dinero. La simulacion termina. ***");
                    continuar = false;
                    break;
                }

                MostrarEstadoGeneral();
                MostrarCuadricula();
                MostrarMenu();

                int opcion = LeerEnteroValidado("Ingrese una opcion: ", 1, 5);

                if (opcion == 1)
                {
                    OpcionSembrar();
                }
                else if (opcion == 2)
                {
                    OpcionRegar();
                }
                else if (opcion == 3)
                {
                    OpcionConsultarParcela();
                }
                else if (opcion == 4)
                {
                    OpcionAvanzarMes();

                    // Verificar si se acabo el dinero despues de pagar empleados
                    if (granja.Dinero <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("*** Se acabo el dinero. La simulacion termina. ***");
                        continuar = false;
                    }
                }
                else if (opcion == 5)
                {
                    continuar = false;
                }
            }

            // Mostrar reporte final
            MostrarReporteFinal();

            Console.WriteLine();
            Console.WriteLine("Presione ENTER para salir...");
            Console.ReadLine();
        }

        // ==================== CONFIGURACION INICIAL ====================
        static void ConfigurarGranja()
        {
            Console.WriteLine("--- CONFIGURACION INICIAL DE LA GRANJA ---");
            Console.WriteLine();

            double dinero = LeerDoubleValidado("Ingrese la cantidad de dinero inicial (mayor a 0): ", 1, double.MaxValue);
            int empleados = LeerEnteroValidado("Ingrese el numero de empleados (mayor a 0): ", 1, int.MaxValue);
            double sueldo = LeerDoubleValidado("Ingrese el sueldo por empleado (mayor a 0): ", 1, double.MaxValue);
            int meses = LeerEnteroValidado("Ingrese los meses a simular (mayor a 0): ", 1, int.MaxValue);
            int filas = LeerEnteroValidado("Ingrese la cantidad de filas de parcelas (1-10): ", 1, 10);
            int columnas = LeerEnteroValidado("Ingrese la cantidad de columnas de parcelas (1-10): ", 1, 10);

            granja = new Granja(dinero, empleados, sueldo, meses, filas, columnas);

            Console.WriteLine();
            Console.WriteLine("Granja configurada correctamente.");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        // ==================== MOSTRAR ESTADO GENERAL ====================
        static void MostrarEstadoGeneral()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("   ESTADO DE LA GRANJA");
            Console.WriteLine("================================================");
            Console.WriteLine("Dinero disponible : Q" + granja.Dinero.ToString("F2"));
            Console.WriteLine("Empleados         : " + granja.NumeroEmpleados);
            Console.WriteLine("Sueldo/empleado   : Q" + granja.SueldoPorEmpleado.ToString("F2"));
            Console.WriteLine("Meses restantes   : " + granja.MesesRestantes);
            Console.WriteLine("Meses simulados   : " + granja.MesesSimulados);
            Console.WriteLine("================================================");
        }

        // ==================== CUADRICULA ====================
        static void MostrarCuadricula()
        {
            Console.WriteLine();
            Console.WriteLine("--- CUADRICULA DE PARCELAS ---");

            // Encabezado de columnas
            Console.Write("       ");
            for (int c = 0; c < granja.Columnas; c++)
            {
                Console.Write("  Col" + (c + 1) + "  ");
            }
            Console.WriteLine();

            // Filas de la cuadricula
            for (int f = 0; f < granja.Filas; f++)
            {
                Console.Write("Fila " + (f + 1) + " ");
                for (int c = 0; c < granja.Columnas; c++)
                {
                    Parcela p = granja.Parcelas[f, c];
                    string simbolo = "";

                    if (p.TipoCultivo == "Vacia")
                    {
                        simbolo = " [VAC] ";
                    }
                    else if (p.TipoCultivo == "Papa")
                    {
                        simbolo = " [PAP] ";
                    }
                    else if (p.TipoCultivo == "Tomate")
                    {
                        simbolo = " [TOM] ";
                    }
                    else if (p.TipoCultivo == "Fresa")
                    {
                        simbolo = " [FRE] ";
                    }

                    // Indicar si fue regada este mes
                    if (p.RegadaEsteMes && p.TipoCultivo != "Vacia")
                    {
                        simbolo = " [REG] ";
                    }

                    Console.Write(simbolo + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Referencia: [VAC]=Vacia  [PAP]=Papa  [TOM]=Tomate  [FRE]=Fresa  [REG]=Regada");
            Console.WriteLine();
        }

        // ==================== MOSTRAR MENU ====================
        static void MostrarMenu()
        {
            Console.WriteLine("--- MENU DE OPCIONES ---");
            Console.WriteLine("1. Sembrar");
            Console.WriteLine("2. Regar parcela");
            Console.WriteLine("3. Consultar parcela");
            Console.WriteLine("4. Avanzar de mes");
            Console.WriteLine("5. Salir");
            Console.WriteLine();
        }

        // ==================== OPCION 1: SEMBRAR ====================
        static void OpcionSembrar()
        {
            Console.Clear();
            Console.WriteLine("--- SEMBRAR ---");
            Console.WriteLine();

            int fila = LeerEnteroValidado("Ingrese la fila (1-" + granja.Filas + "): ", 1, granja.Filas) - 1;
            int columna = LeerEnteroValidado("Ingrese la columna (1-" + granja.Columnas + "): ", 1, granja.Columnas) - 1;

            Parcela p = granja.Parcelas[fila, columna];

            // Validar que la parcela este vacia
            if (p.TipoCultivo != "Vacia")
            {
                Console.WriteLine("La parcela ya tiene siembra de tipo: " + p.TipoCultivo);
                Console.WriteLine("No se puede sembrar en una parcela ocupada.");
                Console.WriteLine("Presione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            // Mostrar tipos de siembra disponibles
            Console.WriteLine();
            Console.WriteLine("Tipos de siembra disponibles:");
            Console.WriteLine("1. Papa   (2 meses para crecer - genera Q450)");
            Console.WriteLine("2. Tomate (3 meses para crecer - genera Q650)");
            Console.WriteLine("3. Fresa  (4 meses para crecer - genera Q900)");
            Console.WriteLine();

            int tipo = LeerEnteroValidado("Seleccione el tipo de siembra: ", 1, 3);

            string nombreCultivo = "";
            if (tipo == 1)
            {
                nombreCultivo = "Papa";
                granja.ContadorPapasSembradas++;
            }
            else if (tipo == 2)
            {
                nombreCultivo = "Tomate";
                granja.ContadorTomatesSembrados++;
            }
            else if (tipo == 3)
            {
                nombreCultivo = "Fresa";
                granja.ContadorFresasSembradas++;
            }

            p.Sembrar(nombreCultivo);

            Console.WriteLine();
            Console.WriteLine("Se ha sembrado " + nombreCultivo + " en la parcela [Fila " + (fila + 1) + ", Col " + (columna + 1) + "].");
            Console.WriteLine("Crecera en " + p.MesesNecesarios + " mes(es).");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        // ==================== OPCION 2: REGAR ====================
        static void OpcionRegar()
        {
            Console.Clear();
            Console.WriteLine("--- REGAR PARCELA ---");
            Console.WriteLine("Costo de riego: Q40");
            Console.WriteLine();

            int fila = LeerEnteroValidado("Ingrese la fila (1-" + granja.Filas + "): ", 1, granja.Filas) - 1;
            int columna = LeerEnteroValidado("Ingrese la columna (1-" + granja.Columnas + "): ", 1, granja.Columnas) - 1;

            Parcela p = granja.Parcelas[fila, columna];

            // Validar que tenga siembra
            if (p.TipoCultivo == "Vacia")
            {
                Console.WriteLine("La parcela esta vacia. Solo se puede regar una parcela con siembra.");
                Console.WriteLine("Presione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            // Validar que no haya sido regada este mes
            if (p.RegadaEsteMes)
            {
                Console.WriteLine("Esta parcela ya fue regada en este mes. Solo se puede regar una vez por mes.");
                Console.WriteLine("Presione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            // Validar que haya suficiente dinero
            if (granja.Dinero < 40)
            {
                Console.WriteLine("No hay suficiente dinero para regar. Se necesitan Q40.");
                Console.WriteLine("Presione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            // Realizar el riego
            granja.Dinero -= 40;
            granja.TotalEgresos += 40;
            p.RegadaEsteMes = true;
            granja.ContadorRiegos++;

            Console.WriteLine();
            Console.WriteLine("Parcela [Fila " + (fila + 1) + ", Col " + (columna + 1) + "] regada correctamente.");
            Console.WriteLine("Se descontaron Q40. Dinero restante: Q" + granja.Dinero.ToString("F2"));
            Console.WriteLine("Al avanzar de mes, esta parcela crecera 2 meses en lugar de 1.");
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        // ==================== OPCION 3: CONSULTAR PARCELA ====================
        static void OpcionConsultarParcela()
        {
            Console.Clear();
            Console.WriteLine("--- CONSULTAR PARCELA ---");
            Console.WriteLine();

            int fila = LeerEnteroValidado("Ingrese la fila (1-" + granja.Filas + "): ", 1, granja.Filas) - 1;
            int columna = LeerEnteroValidado("Ingrese la columna (1-" + granja.Columnas + "): ", 1, granja.Columnas) - 1;

            Parcela p = granja.Parcelas[fila, columna];

            Console.WriteLine();
            Console.WriteLine("--- Informacion de Parcela [Fila " + (fila + 1) + ", Col " + (columna + 1) + "] ---");

            if (p.TipoCultivo == "Vacia")
            {
                Console.WriteLine("Estado: Disponible para siembra.");
            }
            else
            {
                Console.WriteLine("Tipo de cultivo    : " + p.TipoCultivo);
                Console.WriteLine("Estado crecimiento : " + p.MesesCrecimiento + " / " + p.MesesNecesarios + " mes(es)");

                string regada = "No";
                if (p.RegadaEsteMes)
                {
                    regada = "Si";
                }
                Console.WriteLine("Regada este mes    : " + regada);
                Console.WriteLine("Ingreso al cosechar: Q" + p.IngresosCosecha);
            }

            Console.WriteLine();
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        // ==================== OPCION 4: AVANZAR DE MES ====================
        static void OpcionAvanzarMes()
        {
            Console.Clear();
            Console.WriteLine("--- AVANZANDO DE MES ---");
            Console.WriteLine();

            // Paso 1: pagar a empleados
            double costoEmpleados = granja.NumeroEmpleados * granja.SueldoPorEmpleado;
            granja.Dinero -= costoEmpleados;
            granja.TotalEgresos += costoEmpleados;

            Console.WriteLine("Pago de empleados: " + granja.NumeroEmpleados + " empleado(s) x Q" + granja.SueldoPorEmpleado.ToString("F2") + " = Q" + costoEmpleados.ToString("F2"));
            Console.WriteLine("Dinero restante despues de pago: Q" + granja.Dinero.ToString("F2"));
            Console.WriteLine();

            // Paso 2: simular crecimiento y cosecha de cada parcela
            Console.WriteLine("--- Simulacion de crecimiento ---");
            bool algunCambio = false;

            for (int f = 0; f < granja.Filas; f++)
            {
                for (int c = 0; c < granja.Columnas; c++)
                {
                    Parcela p = granja.Parcelas[f, c];

                    if (p.TipoCultivo != "Vacia")
                    {
                        // Determinar cuanto crece este mes
                        int crecimientoEsteMes = 1;
                        if (p.RegadaEsteMes)
                        {
                            crecimientoEsteMes = 2;
                        }

                        p.MesesCrecimiento += crecimientoEsteMes;

                        string mensajeRiego = "";
                        if (p.RegadaEsteMes)
                        {
                            mensajeRiego = " (regada, crecio 2 meses)";
                        }

                        Console.WriteLine("  Parcela [" + (f + 1) + "," + (c + 1) + "] " + p.TipoCultivo + ": crecimiento " + p.MesesCrecimiento + "/" + p.MesesNecesarios + mensajeRiego);
                        algunCambio = true;

                        // Verificar si esta lista para cosechar
                        if (p.MesesCrecimiento >= p.MesesNecesarios)
                        {
                            // Cosechar
                            double ingreso = p.IngresosCosecha;
                            granja.Dinero += ingreso;
                            granja.TotalIngresos += ingreso;

                            // Actualizar contadores de cosecha
                            if (p.TipoCultivo == "Papa")
                            {
                                granja.ContadorCosechasPapa++;
                            }
                            else if (p.TipoCultivo == "Tomate")
                            {
                                granja.ContadorCosechasTomate++;
                            }
                            else if (p.TipoCultivo == "Fresa")
                            {
                                granja.ContadorCosechasFresa++;
                            }

                            Console.WriteLine("  *** COSECHA: Parcela [" + (f + 1) + "," + (c + 1) + "] - " + p.TipoCultivo + " cosechado. Se obtuvieron Q" + ingreso.ToString("F2") + " ***");

                            p.Vaciar();
                        }

                        // Reiniciar estado de riego para el siguiente mes
                        p.RegadaEsteMes = false;
                    }
                }
            }

            if (!algunCambio)
            {
                Console.WriteLine("  No hay parcelas sembradas que simular.");
            }

            // Paso 3: actualizar contadores de meses
            granja.MesesRestantes--;
            granja.MesesSimulados++;

            Console.WriteLine();
            Console.WriteLine("--- Fin del mes " + granja.MesesSimulados + " ---");
            Console.WriteLine("Meses restantes: " + granja.MesesRestantes);
            Console.WriteLine("Dinero actual  : Q" + granja.Dinero.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        // ==================== REPORTE FINAL ====================
        static void MostrarReporteFinal()
        {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("         REPORTE FINAL DE LA SIMULACION        ");
            Console.WriteLine("================================================");
            Console.WriteLine();

            // Contar parcelas vacias al finalizar
            int parcelasVacias = 0;
            for (int f = 0; f < granja.Filas; f++)
            {
                for (int c = 0; c < granja.Columnas; c++)
                {
                    if (granja.Parcelas[f, c].TipoCultivo == "Vacia")
                    {
                        parcelasVacias++;
                    }
                }
            }

            Console.WriteLine("--- Resumen economico ---");
            Console.WriteLine("Dinero final          : Q" + granja.Dinero.ToString("F2"));
            Console.WriteLine("Total de ingresos     : Q" + granja.TotalIngresos.ToString("F2"));
            Console.WriteLine("Total de egresos      : Q" + granja.TotalEgresos.ToString("F2"));
            Console.WriteLine("Meses simulados       : " + granja.MesesSimulados);
            Console.WriteLine();

            Console.WriteLine("--- Parcelas sembradas ---");
            Console.WriteLine("Papa sembrada(s)      : " + granja.ContadorPapasSembradas);
            Console.WriteLine("Tomate sembrado(s)    : " + granja.ContadorTomatesSembrados);
            Console.WriteLine("Fresa sembrada(s)     : " + granja.ContadorFresasSembradas);
            Console.WriteLine();

            Console.WriteLine("--- Cosechas realizadas ---");
            Console.WriteLine("Cosechas de Papa      : " + granja.ContadorCosechasPapa);
            Console.WriteLine("Cosechas de Tomate    : " + granja.ContadorCosechasTomate);
            Console.WriteLine("Cosechas de Fresa     : " + granja.ContadorCosechasFresa);
            Console.WriteLine();

            Console.WriteLine("--- Otros datos ---");
            Console.WriteLine("Total de riegos       : " + granja.ContadorRiegos);
            Console.WriteLine("Parcelas vacias final : " + parcelasVacias);
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("         FIN DE LA SIMULACION                  ");
            Console.WriteLine("================================================");
        }

        // ==================== METODOS DE VALIDACION ====================

        // Lee y valida un numero entero dentro de un rango
        static int LeerEnteroValidado(string mensaje, int min, int max)
        {
            int valor = 0;
            bool valido = false;

            while (!valido)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out valor))
                {
                    if (valor >= min && valor <= max)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Valor fuera de rango. Debe estar entre " + min + " y " + max + ".");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Ingrese un numero entero.");
                }
            }

            return valor;
        }

        // Lee y valida un numero decimal dentro de un rango
        static double LeerDoubleValidado(string mensaje, double min, double max)
        {
            double valor = 0;
            bool valido = false;

            while (!valido)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out valor))
                {
                    if (valor >= min && valor <= max)
                    {
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Valor fuera de rango. Debe ser mayor a " + min + ".");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Ingrese un numero valido.");
                }
            }

            return valor;
        }
    }
}