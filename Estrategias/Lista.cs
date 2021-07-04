using System; 
using System.Collections.Generic;
using System.Text; 
using Actividad3.Estrategias; 

namespace Actividad3 
{
    public class Lista 
        { 
            public Lista()
            {
                Ahorro ahorro = new Ahorro();

                Cauto cauto = new Cauto(); 

                Emergencia emergencia = new Emergencia(); 
            }

            List<Lista> Estra = new List<Lista>(){ahorro, cauto, emergencia}; 
        }
}
    