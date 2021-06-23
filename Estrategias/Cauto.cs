using System; 
using System.Collections.Generic;
using System.Text;

namespace  Actividad3.Estrategias
{
    public class Cauto 
    {
        public void Acreditar(double monto)
        {
            Efectivo = Efectivo + monto * 0.8;

            Cuenta.acreditar(monto * 0.2);
        }

        public void Debitar(double monto)
        {
            Efectivo = Efectivo - monto * 0.8; 

            Cuenta.debitar(monto * 0.2);
        }
    }
}