using System;
using FundamentosC_.Models;


namespace FundamentosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            /*for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("iteración: "+i+" - "+numeros[i]);
            /*
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }*/
            /*List<int> lista = new List<int>() { 0,1,2,3,4,5,6,7,8,9};
            lista.Add(10);
            lista.Add(11);
            lista.Remove(1);
            foreach (var numero in lista)
            {
                Console.WriteLine("elemento: "+numero);

            }*/
            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza("heineken", 500) };
            cervezas.Add(new Cerveza("Biela", 500));
            Cerveza brahma = new Cerveza("cerveza de trigo", 1000);
            cervezas.Add(brahma);

            foreach (var objetos in cervezas) {
                Console.WriteLine(objetos.Nombre);
            }
        }
    }
}

