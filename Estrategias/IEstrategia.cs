using System; 
using System.Collections.Generic;
using System.Text;

namespace Actividad3.Estrategias
{
    public interface IEstrategia
    {
        void Debitar (Cliente cliente, double monto);

        void Acreditar (Cliente cliente, double monto);

        void EsApto (Cliente cliente);
    }
}