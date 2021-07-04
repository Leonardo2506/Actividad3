using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad3
{
    public class Cuenta
    {
        private static int Contador { get; set; } = 0;

        public int Cbu { get; set; } = 0;

        public double Saldo { get; set; } = 0;

        public Cuenta()
        {
            Contador++;

            Cbu = Contador;

            Saldo = 0;

        }

        public void acreditar(double monto)
        {
            Saldo = Saldo + monto; 
        }

        public void debitar(double monto)
        {
            Saldo = Saldo - monto;
        }

        public bool TieneAlMenos(double monto) => Saldo >= monto;

        internal double VaciarCuenta()
        {
            var saldo = this.Saldo;
            Saldo = 0; 
            return saldo;
        }

    }
}
