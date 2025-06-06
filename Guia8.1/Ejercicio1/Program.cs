using Ejercicio1.Models;

namespace Ejercicio1
{
    internal class Program
    {
        static Servicio servicio = new Servicio();


        #region metodos de pantalla
        static int MostrarPantallaSolicitarOpcionesMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\tEjercicio1\n\n");
            Console.WriteLine("1. - procesar un solo numero.");
            Console.WriteLine("2. - procesar varios numeros.");
            Console.WriteLine("3. - mostrar maximo y minimo.");
            Console.WriteLine("4. - Mostrar promedio.");
            Console.WriteLine("5. - mostrar cantidad de numeros ingresados.");
            Console.WriteLine("6. - reiniciar variables.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarInicializarVariables()
        {
            servicio.acumulador = 0;
            servicio.contador = 0;
            servicio.maximo = 0;
            servicio.minimo = 0;
            Console.Clear();
            Console.WriteLine("\t\t Reiniciar variables. \n\n");
            Console.WriteLine("se reiniciaron las variables correctamente\n\n");
            Console.WriteLine("presione enter para seguir");
            Console.ReadKey();
        }

        static void SolicitarPantallaIngresarNumero()
        {
            Console.Clear();
            Console.WriteLine("\t\t solicitud de valor a el usuario\n\n");
            Console.WriteLine("ingrese un numero");
            int valor = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(valor);
        }

        static void SolicitarPantallaIngresarVariosNumero()
        {
            Console.Clear();
            Console.WriteLine("\t\t Procesar varios valores a el usuario\n\n");
            Console.WriteLine("ingrese numeros o escriba -1 para salir");
            int valor = Convert.ToInt32(Console.ReadLine());
            while (valor != -1)
            {
                if (valor != -1)
                {
                    servicio.RegistrarValor(valor);
                }
                Console.Clear();
                Console.WriteLine("\t\t Procesar varios valores a el usuario\n\n");
                Console.WriteLine("ingrese numeros o escriba -1 para salir");
                valor = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void MostrarMaximoyMinimo()
        {
            Console.Clear();
            Console.WriteLine("\t\t mostrar maximo y minimo. \n\n");
            if (servicio.contador != 0)
            {
                Console.WriteLine($"Maximo: {servicio.maximo}");
                Console.WriteLine($"Minimo: {servicio.minimo}\n\n\n");
            }
            else
            {
                Console.WriteLine("no hubo ingresos todavia\n\n");
            }
            Console.WriteLine("presione enter para seguir");
            Console.ReadKey();
        }

        static void MostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine("\t\t Mostrar promedio \n\n");
            if (servicio.contador != 0)
            {
                double prom = servicio.CalcularPromedio();
                Console.WriteLine($"el promedio es: {prom}\n\n\n");
            }
            else
            {
                Console.WriteLine("no hubo ingresos todavia\n\n");
            }
            Console.WriteLine("presione enter para seguir");
            Console.ReadKey();
        }

        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine("\t\t Mostrar cantidad de numeros \n\n\n");

            Console.WriteLine($"la cantidad de numeros ingresados es: {servicio.contador}\n\n\n");

            Console.WriteLine("presione enter para seguir");
            Console.ReadKey();
        }
        #endregion

        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionesMenu();
            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        SolicitarPantallaIngresarNumero();
                        break;

                    case 2:
                        SolicitarPantallaIngresarVariosNumero();
                        break;

                    case 3:
                        MostrarMaximoyMinimo();
                        break;

                    case 4:
                        MostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        MostrarInicializarVariables();
                        break;

                    default:
                        op = -1;
                        break;
                }
                if (op != -1)
                {
                    op = MostrarPantallaSolicitarOpcionesMenu();
                }
            }
        }
    }
}
