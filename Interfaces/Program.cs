using System;
using FundamentosC_.Models;


namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            var bebidaAlcoholica = new Vino("Gato Negro", 100);
            MostrarRecomendacion(bebidaAlcoholica);
        }
        static void MostrarRecomendacion(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();
        }
    }
}

