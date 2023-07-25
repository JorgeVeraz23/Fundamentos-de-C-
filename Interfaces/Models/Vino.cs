using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido son 3 copas");
        }
        public Vino(string Nombre, int Cantidad) : base(Nombre, Cantidad)//base hace referencia al constructor de su padre
        {

        }


    }
}
