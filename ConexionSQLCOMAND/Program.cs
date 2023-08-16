using System;
using ConexionSQLCOMAND.Models;

namespace ConexionSQLCOMAND
{
    class Program
    {
        static void Main(string[] args)
        {
            CervezaBD cerverzaBd = new CervezaBD();
            var cervezas = cerverzaBd.Get();

            foreach(var cerverza in cervezas)
            {
                
                Console.WriteLine("Cantidad: "+cerverza.Cantidad);
                Console.WriteLine("Marca: "+cerverza.Marca);
                Console.WriteLine("Nombre: "+cerverza.Nombre);
                Console.WriteLine("Alcohol: "+cerverza.Alcohol);
                Console.WriteLine("-------------------------");
            }
        }
        
    }
}

