using System; 
using System.Collections.Generic;
using System.Text;
using Actividad3;

namespace  Actividad3.Estrategias
{
    public class Cauto : IEstrategia 
    {
        public void Acreditar(Cliente cliente, double monto)
        {
            cliente.AcreditarEfectivo(monto * 0.8);

            cliente.Cuenta.acreditar(monto * 0.2);
        }

        public void Debitar(Cliente cliente, double monto)
        {
            cliente.DebitarEfectivo(monto * 0.8); 

            cliente.Cuenta.debitar(monto * 0.2);
        }

        public bool EsApto(Cliente cliente)
            => cliente.Efectivo >= 10000 && cliente.Efectivo <= 50000;  
    }
}