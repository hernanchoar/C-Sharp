using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejer_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int linea;
            do
            {
                Juego_De_Dados inicio = new Juego_De_Dados();
                inicio.Jugar();
                Console.WriteLine("Desea jugar nuevamente pulse 1 ");
                linea = Convert.ToInt32(Console.ReadLine());
            } while (linea == 1);
        }
    }
}