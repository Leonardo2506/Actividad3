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
            cliente.AcreditarEfectivo(monto); 
        }

        public void Debitar(Cliente cliente, double monto)
        {
            if (cliente.Cuenta.TieneAlMenos(monto) )
            {
                cliente.Cuenta.debitar(monto);
            }
            else
            {
                monto -= cliente.Cuenta.VaciarCuenta();
                cliente.DebitarEfectivo(monto); 
            }
        }
        public bool EsApto(Cliente cliente) => cliente.Efectivo < 10000; 
    }
}