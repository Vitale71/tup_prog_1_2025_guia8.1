using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Servicio
    {
        #region resolucion del problema
        public int acumulador;
        public int contador;
        public int maximo;
        public int minimo;
        #endregion
        public double CalcularPromedio()
        {
            double prom = 0;
            if (contador != 0)
            {
                prom = 1.0 * acumulador / contador;
            }
            return prom;
        }
        public void RegistrarValor(int valor)
        {
            acumulador += valor;

            if (valor > maximo || contador == 0)
            {
                maximo = valor;
            }

            if (valor < minimo || contador == 0)
            {
                minimo = valor;
            }
            contador += 1;
        }
    }
}
