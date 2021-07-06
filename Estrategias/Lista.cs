using System; 
using System.Collections.Generic;
using System.Text;  
using System.Linq;
using Actividad3.Estrategias;

namespace Actividad3 
{
    public class Lista 
        { 
            List<IEstrategia> Estra = new List<IEstrategia>()
            {
                new Ahorro(),

                new Cauto(),

                new Emergencia(),
            };
            

            public IEstrategia EstrategiaPara(Cliente cliente)
            {
                List<IEstrategia> TipoEstrategia = Estra.FirstOrDefault(Estra => IEstrategia.EsApto = true );

                return (Estrategia);  
            } 
        
            
            
            
            

            
                 
    
        
            
            
            
            

        }
}
    