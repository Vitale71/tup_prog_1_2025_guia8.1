using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Servicio
    {
        #region resolucion del problema
        public int edad1;
        public int edad2;
        public int edad3;
        public int edad4;
        public double monto;
        public double porcentaje1;
        public double porcentaje2;
        public double porcentaje3;
        public double porcentaje4;
        public double monto1;
        public double monto2;
        public double monto3;
        public double monto4;
        #endregion

        public double RegistrarMontoArepartir(double montoRegistrado)
        {
            monto = montoRegistrado;
            return monto;
        }
        public int RegistrarEdad(int edadNiña, int nroNiña)
        {
            if (nroNiña == 1)
            {
                edad1 = edadNiña;
            }
            if (nroNiña == 2)
            {
                edad2 = edadNiña;
            }
            if (nroNiña == 3)
            {
                edad3 = edadNiña;
            }
            if (nroNiña == 4)
            {
                edad4 = edadNiña;
            }
            return edadNiña;
        }
        public void CalcularMontosYporcentajesARepartir()
        {

            int edadTotal = edad1 + edad2 + edad3 + edad4;
            porcentaje1 = (edad1 * 100) / edadTotal;
            porcentaje2 = (edad2 * 100) / edadTotal;
            porcentaje3 = (edad3 * 100) / edadTotal;
            porcentaje4 = (edad4 * 100) / edadTotal;
            monto1 = (porcentaje1 * monto) / 100;
            monto2 = (porcentaje2 * monto) / 100;
            monto3 = (porcentaje3 * monto) / 100;
            monto4 = (porcentaje4 * monto) / 100;
        }

    }
}
