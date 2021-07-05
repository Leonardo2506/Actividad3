using System; 
using System.Collections.Generic;
using System.Text; 
using Actividad3.Estrategias; 

namespace Actividad3 
{
    public class Lista 
        { 
            List<IEstrategia> Estra = new List<IEstrategia>()
            {
                new Ahorro(),

                new Cauto(),

                new Emergencia()
            };

        }
}
    