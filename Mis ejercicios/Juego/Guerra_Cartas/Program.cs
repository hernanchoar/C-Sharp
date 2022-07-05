using System;

namespace Guerra_Cartas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Juego_De_Cartas inicio = new Juego_De_Cartas();


            int i = 0;
            
            do
            {
                inicio.Jugar();
                Console.WriteLine(i);
                i++;
                
            } while (i < 3);
            
        }
    }
}