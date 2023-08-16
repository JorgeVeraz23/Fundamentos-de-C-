using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionSQLCOMAND.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }
        public string Marca { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido son 10");
        }
        public Cerveza(string Nombre, int Cantidad) : base(Nombre, Cantidad)//base hace referencia al constructor de su padre
        {

        }

        
    }
}
