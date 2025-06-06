using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    internal class Servicio
    {
        public string jugado1;
        public string jugado2;
        public int setGanados1;
        public int setGanados2;
        public string RegistrarJugadores(string nombre1, string nombre2)
        {
            jugado1 = nombre1;
            jugado2 = nombre2;
            return nombre1;
        }

        public int RegistrarResultados(int resultado1, int resultado2)
        {
            if (resultado1 > resultado2)
            {
                setGanados1++;
            }
            if (resultado2 > resultado1)
            {
                setGanados2++;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t\t Registrar los resultados de cada set de los jugadores.\n\n");
                Console.WriteLine("Hubo un empate de puntos \n\n");
                Console.WriteLine("presione enter para seguir");
                Console.ReadKey();
            }
            return resultado1;
        }

        public string DeterminarGanador(string jugadorGanador)
        {
            if (setGanados1 > setGanados2)
            {
                jugadorGanador = jugado1;
            }
            if (setGanados2 > setGanados1)
            {
                jugadorGanador = jugado2;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t\t Registrar los resultados de cada set de los jugadores.\n\n");
                Console.WriteLine("Hubo un empate de sets \n\n");
                Console.WriteLine("presione enter para seguir");
                Console.ReadKey();
            }
            return jugadorGanador;
        }
    }
}
