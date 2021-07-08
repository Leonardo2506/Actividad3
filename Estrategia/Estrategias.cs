using System; 
using System.Collections.Generic;
using System.Text;  
using System.Linq;
using Actividad3; 

namespace Actividad3.Estrategias 
{
    public static class Estrategias
        { 
            static List<IEstrategia> Estra = new List<IEstrategia>()
            {
                new Ahorro(),

                new Cauto(),

                new Emergencia(),
            };
            

            public static IEstrategia EstrategiaPara(Cliente cliente)
            {
                return (Estra.FirstOrDefault(e => e.EsApto(cliente)));
            }
        }
}
    