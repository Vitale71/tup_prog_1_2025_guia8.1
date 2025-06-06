using Ejercicio2.Models;
namespace Ejercicio2
{ 
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region metodos de pantalla
        static int MostrarPantallaSolicitarOpcionesMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\tEjercicio2\n\n");
            Console.WriteLine("1 - Iniciar Monto a repartir.");
            Console.WriteLine("2 - Solicitar Edad Por niña.");
            Console.WriteLine("3 - Mostrar monto y porcentajes que corresponde a cada niña.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("\t\t Registrar monto a repartir. \n\n");
            Console.WriteLine("ingrese el monto a repartir\n\n");
            int valor = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarMontoArepartir(valor);
        }

        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.Clear();
            Console.WriteLine("\t\t Solicitar edad por niña.\n\n");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese la edad de la niña numero {0}", i);
                int edad = Convert.ToInt32(Console.ReadLine());
                if (edad >= 1 && edad <= 18)
                {
                    servicio.RegistrarEdad(edad, i);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\t\t Solicitar edad por niña.\n\n");
                    Console.WriteLine("edad de la niña no registrada numeros no validos. \n\n");
                    Console.WriteLine("presione enter para seguir");
                    Console.ReadKey();
                    i--;
                }
            }
        }

        static void MostrarPantallaCalcularMostrarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("\t\t Mostrar monto y porcentajes que corresponde a cada niña. \n\n");
            if (servicio.monto != 0)
            {
                if (servicio.edad1 != 0 && servicio.edad2 != 0 && servicio.edad3 != 0 && servicio.edad4 != 0)
                {
                    servicio.CalcularMontosYporcentajesARepartir();
                    Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}", servicio.edad1, servicio.porcentaje1, servicio.monto1);
                    Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}", servicio.edad2, servicio.porcentaje2, servicio.monto2);
                    Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}", servicio.edad3, servicio.porcentaje3, servicio.monto3);
                    Console.WriteLine("niña edad: {0} el porcentaje es {1} el monto correspondiente: {2}\n\n", servicio.edad4, servicio.porcentaje4, servicio.monto4);
                    Console.WriteLine("presione enter para seguir");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("faltan edades que ingresar para mostrar los datos\n\n");
                    Console.WriteLine("presione enter para seguir");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("falta el monto a repartir para mostrar los datos\n\n");
                Console.WriteLine("presione enter para seguir");
                Console.ReadKey();
            }
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
                        MostrarPantallaSolicitarMontoARepartir();
                        break;

                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;

                    case 3:
                        MostrarPantallaCalcularMostrarMontoARepartir();
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
