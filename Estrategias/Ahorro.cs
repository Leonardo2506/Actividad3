using System; 
using System.Collections.Generic;
using System.Text;

namespace  Actividad3.Estrategias
{
    public class Ahorro 
    {
        public void Acreditar(double monto)
        {
            Efectivo = Efectivo + monto * 0.5;

            Cuenta.acreditar(monto * 0.5);
        }

        public void Debitar(double monto)
        {
            Efectivo = Efectivo - monto * 0.5;

            Cuenta.debitar(monto * 0.5);
        }
    }
}