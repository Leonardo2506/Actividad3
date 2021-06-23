using System; 
using System.Collections.Generic;
using System.Text;
using Actividad3; 

namespace  Actividad3.Estrategias
{
    public class Ahorro : IEstrategia
    {
        public void Acreditar(Cliente cliente, double monto)
        {
            cliente.Efectivo += monto * 0.5;

            cliente.Cuenta.acreditar(monto * 0.5);
        }

        public void Debitar(Cliente cliente, double monto)
        {
            if(cliente.TieneAlMenos(monto))
        }  

        public bool EsApto(Cliente cliente) => cliente.Efectivo > 50000; 

    }
}