using System;

namespace Practica_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Coche coche = new Coche();
            Concesionario concesionario = new Concesionario();
         //  Console.WriteLine(coche.ToString());

         
         
         Console.WriteLine("Introduzca el auto que desea agregar");
         string entrada1;
         entrada1 = Console.ReadLine();
         concesionario.Aniadir_Coche(entrada1);
         
         


        }
    }
}