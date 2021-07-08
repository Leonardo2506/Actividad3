using System; 
using System.Collections.Generic;
using System.Text;
using Actividad3.Estrategias;

namespace  Actividad3.Estrategias
{
    public class Cliente
    {
        public string Nombre {get; set;}

        public string Apellido {get; set;}

        public double Efectivo {get; internal set;} = 0;

        public Cuenta Cuenta { get; set;}

        public IEstrategia Estrategia {get; set;}

        public Cliente()
        {
            Cuenta = new Cuenta(); 
        }

        public double Saldo => Efectivo + Cuenta.Saldo;

        public int Cbu => Cuenta.Cbu;

        public void Acreditar(double monto) 
        {
            Estrategia.Acreditar(this, monto);

            if(!Estrategia.EsApto(this))
            {
                Estrategias.EstrategiaPara(this);
            }
        } 

        public void Debitar(double monto)
        {
            Estrategia.Debitar(this, monto);

            if(!Estrategia.EsApto(this))
            {
                Estrategias.EstrategiaPara(this); 
            }
        }

        public void AcreditarEfectivo(double monto) => Efectivo += monto;

        public void DebitarEfectivo(double monto) => Efectivo -= monto;

        public bool TieneAlMenos(double monto) => Saldo >= monto;

        internal double VaciarEfectivo()
        {
            var efectivo = this.Efectivo; 
            Efectivo = 0; 
            return efectivo; 
        }
    }
}