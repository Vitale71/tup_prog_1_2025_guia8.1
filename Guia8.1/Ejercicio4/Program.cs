using Ejercicio4.Models;

namespace Ejercicio4
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        static int MostrarPantallaSolicitarOpcionesMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\tEjercicio2\n\n");
            Console.WriteLine("1 - Registrar los nombres de los dos jugadores.");
            Console.WriteLine("2 - Registrar los resultados de cada set de los jugadores.");
            Console.WriteLine("3 - Mostrar el ganador.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.Clear();
            Console.WriteLine("\t\t Registrar los nombres de los dos jugadores.\n\n");
            Console.WriteLine("ingrese el nombre del jugador1");
            string jug1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\t\t Registrar los nombres de los dos jugadores.\n\n");
            Console.WriteLine("ingrese el nombre del jugador2");
            string jug2 = Console.ReadLine();
            servicio.RegistrarJugadores(jug1, jug2);
        }

        static void MostrarPantallaSolicitarResultadoSet()
        {
            Console.Clear();
            Console.WriteLine("\t\t Registrar los resultados de cada set de los jugadores.\n\n");
            Console.WriteLine("ingrese los resultados del set del jugador1");
            int jug1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\t\t Registrar los resultados de cada set de los jugadores.\n\n");
            Console.WriteLine("ingrese los resultados del set del jugador2");
            int jug2 = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarResultados(jug1, jug2);
        }

        static void MostrarPantallaGanador()
        {
            string ganador = null;
            Console.Clear();
            Console.WriteLine("\t\t Mostrar el ganador.\n\n");
            if (string.IsNullOrEmpty(servicio.jugado1) || string.IsNullOrEmpty(servicio.jugado2))
            {
                Console.WriteLine("Falta el nombre de un jugador.\n\n");
                Console.WriteLine("presione enter para seguir");
                Console.ReadKey();
            }
            else
            {
                if (servicio.setGanados1 == 0 && servicio.setGanados2 == 0)
                {
                    Console.WriteLine("Todavia no se jugaron ningun sets.\n\n");
                    Console.WriteLine("presione enter para seguir");
                    Console.ReadKey();
                }
                else
                {
                    ganador = servicio.DeterminarGanador(ganador);
                    Console.WriteLine("El ganador del partido de tenis es {0} \n\n", ganador);
                    Console.WriteLine("presione enter para seguir");
                    Console.ReadKey();
                }
            }


        }


        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionesMenu();
            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarNombreJugadores();
                        break;

                    case 2:
                        MostrarPantallaSolicitarResultadoSet();
                        break;

                    case 3:
                        MostrarPantallaGanador();
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
