namespace Actividad3.Estrategias
{
    public interface IEstrategia
    {
        void Debitar (Cliente cliente, double monto);

        void Acreditar (Cliente cliente, double monto);

        bool EsApto (Cliente cliente);
    }
}