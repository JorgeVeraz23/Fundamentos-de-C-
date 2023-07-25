using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosC_.Models
{
    internal class Cerveza : Bebida
    {
        public Cerveza(string Nombre, int Cantidad) : base(Nombre, Cantidad)//base hace referencia al constructor de su padre
        {

        }
    }
}
