using System;
using FundamentosC_.Models;


namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bebida bebida = new Bebida("Coca cola", 1000);
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);*/
            Cerveza cerveza = new Cerveza();
            cerveza.Beberse(10);
        }
    }
}
