using System; 
using System.Collections.Generic;
using System.Text;
using Actividad3;

namespace  Actividad3.Estrategias
{
    public class Emergencia : IEstrategia
    {
        public void Acreditar(Cliente cliente, double monto)
        {
            cliente.Efectivo += monto; 
        }

        public void Debitar(Cliente cliente, double monto)
        {
            if (cliente.Cuenta.TieneAlMenos(monto) )
            {
                cliente.Cuenta.debitar(monto);
            }else
            {
                
            }
        }

    }
}